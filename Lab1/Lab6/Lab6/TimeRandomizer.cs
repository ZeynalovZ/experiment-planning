using System;

namespace Lab6
{
    interface ITimeRandomizer
    {
        int NextInt(int minValue, int maxValue);
        double NextDouble(int minValue, int maxValue);

        double NextDoubleExponential(double lambda);
        double NextDoubleUniform(double intensity, double dispersion);
    }

    class StdTimeRandomizer : ITimeRandomizer
    {
        private readonly Random _random = new Random();

        public int NextInt(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue + 1);
            
        }

        public double NextDoubleUniform(double intensity, double dispersion)
        {
            if (intensity == dispersion)
            {
                dispersion -= 0.1;
            }
            var a = 1 / (intensity - dispersion);
            var b = 1 / (intensity + dispersion);


            return a + _random.NextDouble() * (b - a);
        }

        public double NextDoubleExponential(double lambda)
        {
            /*double u;
            u = _random.NextDouble() / 1.99999;
            return -Math.Log(1 - u) / lambda;*/
            return lambda * Math.Exp(-lambda * _random.NextDouble());
            //return (Math.Log(_random.NextDouble() + 1) - Math.Log(0.99999)) / (-lambda);
        }

        public double NextDouble(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue) + _random.NextDouble();
        }
    }
}
