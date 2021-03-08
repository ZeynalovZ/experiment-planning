using System;

namespace Lab6
{
    class Model
    {
        public double TimeInterval { get; set; } = Constants.TimeInterval;

        public int QueueLengthLimit { get; set; } = Constants.QueueLengthLimit;

        public double ClientHasStylistProbability { get; set; } =
            Constants.ClientHasStylistProbability;

        public int MinClientArrivalTime { get; set; } = Constants.MinClientArrivalTime;
        public int MaxClientArrivalTime { get; set; } = Constants.MaxClientArrivalTime;

        public int MinStyleTime { get; set; } = Constants.MinStyleTime;
        public int MaxStyleTime { get; set; } = Constants.MaxStyleTime;

        public int MinStylistDelay { get; set; } = Constants.MinStylistDelay;
        public int MaxStylistDelay { get; set; } = Constants.MaxStylistDelay;

        public double CurrentTime { get; private set; } = 0;
        public int ClientsArrived { get; private set; } = 0;
        public int ClientsDeclined { get; private set; } = 0;
        public int ClientsServed { get; private set; } = 0;

        public double ClientIntensity { get; set; } = 0;

        private Style[] _styles = null;
        private Operator[] _stylists = null;

        private ClientGenerator _clientGenerator = null;
        private Queue _queue = null;

        public void Initialize(int modelingTime, int operatorsNum, int generatorsNum, double operatorIntensity, double operatorDispersion, double generatorIntensity)
        {
            CurrentTime = 0;
            ClientsArrived = 0;
            ClientsDeclined = 0;
            ClientsServed = 0;

            ClientIntensity = generatorIntensity;

            var styleFactory = new StyleFactory(MinStyleTime, MaxStyleTime);
            _styles = new Style[1];
            for (int i = 0; i < 1; i++)
            {
                _styles[i] = styleFactory.Create();
            }

            // intensity = a + b / 2 ; разброс (b - a)^2/12
            var stylistFactory = new OperatorsFactory(operatorIntensity, operatorDispersion);
            _stylists = new Operator[operatorsNum];
            for (int i = 0; i < operatorsNum; i++)
            {
                _stylists[i] = stylistFactory.Create();
            }

            var clientFactory = new ClientFactory();
            _clientGenerator = new ClientGenerator(MinClientArrivalTime,
                MaxClientArrivalTime, clientFactory);

            _queue = new Queue(_stylists, QueueLengthLimit);
        }

        public double Simulate(double duration)
        {
            while (CurrentTime < duration)
            {
                Trace();
            }
            return _queue.GetTimes();
        }

        public void Trace()
        {
            CurrentTime += TimeInterval;

            var newClient = _clientGenerator.Generate(TimeInterval, ClientIntensity);
            if (newClient != null)
            {
                ClientsArrived++;

                if (!_queue.Enqueue(newClient))
                {
                    ClientsDeclined++;
                }
            }

            _queue.MoveOn(TimeInterval);
            foreach (var stylist in _stylists)
            {
                var wasActive = stylist.Active;
                if (!stylist.ContinueServing(TimeInterval) && wasActive)
                {
                    ClientsServed++;
                }
            }
        }
    }
}
