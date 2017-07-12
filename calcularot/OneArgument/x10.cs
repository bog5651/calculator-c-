using System;

namespace calcularot.OneArgument
{
    public class x10 : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Pow(10, firstVlue);
        }
    }
}
