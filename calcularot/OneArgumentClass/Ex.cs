using System;

namespace calcularot.OneArgumentClass
{
    public class Ex : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Pow(Math.E,firstVlue);
        }
    }
}
