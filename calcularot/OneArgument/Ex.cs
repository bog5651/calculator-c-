using System;

namespace calcularot.OneArgument
{
    public class Ex : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Pow(Math.E,firstVlue);
        }
    }
}
