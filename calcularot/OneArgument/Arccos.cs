using System;

namespace calcularot.OneArgument
{
    public class Arccos : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Acos(firstVlue);
        }
    }
}
