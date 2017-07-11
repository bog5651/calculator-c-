using System;

namespace calcularot.OneArgumentClass
{
    public class Tan : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Tan(firstVlue);
        }
    }
}
