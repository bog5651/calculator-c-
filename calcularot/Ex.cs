using System;

namespace calcularot
{
    public class Ex : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Pow(Math.E,firstVlue);
        }
    }
}
