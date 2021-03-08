using System;

namespace Lab6
{
    class Operator
    {
        public bool Active { get; private set; } = false;

        public double IntensityOA { get; set; }
        public double DispersionOA { get; set; }

        public double? TimeLeft { get; private set; } = null;

        private int MaxDelay { get; }
        private readonly ITimeRandomizer _timeRandomizer;

        public Operator(double intensity, double dispersion, ITimeRandomizer timeRand = null)
        {
            _timeRandomizer = timeRand ?? new StdTimeRandomizer();
            IntensityOA = intensity;
            DispersionOA = dispersion;
        }

        public void StartServing(Client client)
        {
            Active = true;
            //int minTime = client.Style.MinTime;
            TimeLeft = _timeRandomizer.NextDoubleUniform(IntensityOA, DispersionOA);
            client.TimeOfExec += (double)TimeLeft;
        }

        public bool ContinueServing(double dT)
        {
            if (Active)
            {
                TimeLeft -= dT;
                if (TimeLeft <= 0)
                {
                    Active = false;
                    TimeLeft = null;
                }
            }
            return Active;
        }
    }
}
