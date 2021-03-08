using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab6
{
    class Queue
    {
        private readonly Operator[] _stylists;
        private readonly Queue<Client> _queue = new Queue<Client>();

        public int LengthLimit { get; }

        List<Client> _resList = new List<Client>();

        public Queue(Operator[] stylists, int lengthLimit)
        {
            _stylists = stylists;
            LengthLimit = lengthLimit;
        }

        public bool Enqueue(Client client)
        {
            if (LengthLimit == -1 || _queue.Count < LengthLimit)
            {
                _queue.Enqueue(client);
                return true;
            }
            return false;
        }

        public void MoveOn(double dT)
        {
            var freeStylists =
                from s in _stylists
                where s.Active == false
                select s;

            var activeStylists = freeStylists as Operator[] ?? freeStylists.ToArray();
            if (!activeStylists.Any())
            {
                return;
            }

            var waitingClients = new Queue<Client>();
            var isStylistActive = new bool[activeStylists.Length];
            while (isStylistActive.Any(x => x == false) && _queue.Count > 0)
            {
                if (_queue.Peek().PersonalStylist == null)
                {
                    for (int i = 0; i < activeStylists.Length; i++)
                    {
                        if (!isStylistActive[i])
                        {
                            isStylistActive[i] = true;
                            var client = _queue.Dequeue();
                            client.TimeOfExec += dT;
                            activeStylists[i].StartServing(client);
                            _resList.Add(client);
                            break;
                        }
                    }
                }
                else
                {
                    bool foundStylist = false;

                    for (int i = 0; i < activeStylists.Length && _queue.Count > 0; i++)
                    {
                        if (activeStylists[i] == _queue.Peek().PersonalStylist && !isStylistActive[i])
                        {
                            isStylistActive[i] = true;
                            var client = _queue.Dequeue();
                            client.TimeOfExec += dT;
                            activeStylists[i].StartServing(client);
                            _resList.Add(client);
                            foundStylist = true;
                        }
                    }

                    if (!foundStylist)
                    {
                        waitingClients.Enqueue(_queue.Dequeue());
                    }
                }
            }

            var tempQueue = new Queue<Client>();
            while (_queue.Count > 0)
            {
                var client = _queue.Dequeue();
                client.TimeOfExec += dT;
                tempQueue.Enqueue(client);
            }

            while (waitingClients.Count > 0)
            {
                var waitingClient = waitingClients.Dequeue();
                waitingClient.TimeOfExec += dT;
                _queue.Enqueue(waitingClient);
            }
            while (tempQueue.Count > 0)
            {
                _queue.Enqueue(tempQueue.Dequeue());
            }
        }

        public double GetTimes()
        {
            var times = new List<double>();
            foreach(var cl in _resList)
            {
                times.Add(cl.TimeOfExec);
            }

            foreach (var cl in _queue)
            {
                times.Add(cl.TimeOfExec);
            }

            var average = times.Average();
            times.Sort();
            return average;
        }
    }
}
