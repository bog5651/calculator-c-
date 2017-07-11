using System;

namespace calcularot.OneArgumentClass
{
    public class Arccos : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Acos(firstVlue);
        }
    }
}
