using System;

namespace calcularot.OneArgument
{
    public class x2 : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Pow(firstVlue, 2);
        }
    }
}
