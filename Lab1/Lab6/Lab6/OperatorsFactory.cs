using System;

namespace Lab6
{
    class OperatorsFactory : IFactory<Operator>
    {
        private readonly ITimeRandomizer _uniformRandomizer;


        public int MinDelay { get; }
        public int MaxDelay { get; }

        public double IntensityOA { get; set; }

        public double DispersionOA { get; set; }

        public ITimeRandomizer DelayRandomizer { get; }

        public OperatorsFactory(double intensityOA, double dispersionOA,
            ITimeRandomizer uniformRandomizer = null)
        {
            _uniformRandomizer = uniformRandomizer ?? new StdTimeRandomizer();
            IntensityOA = intensityOA;
            DispersionOA = dispersionOA;
        }

        public Operator Create()
        {
            return new Operator(IntensityOA, DispersionOA);
        }
    }
}
