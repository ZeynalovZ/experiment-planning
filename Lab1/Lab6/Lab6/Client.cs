using System;

namespace Lab6
{
    class Client
    {
        public string Name { get; }

        public Style Style { get; set; }
        public Operator PersonalStylist { get; set; }

        public double TimeOfExec = 0;

        public Client(string name)
        {
            Name = name;
        }
    }
}
