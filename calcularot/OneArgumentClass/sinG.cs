using System;

namespace calcularot.OneArgumentClass
{
    public class SinG : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Sin(firstVlue * (180 / Math.PI));
        }
    }
}
