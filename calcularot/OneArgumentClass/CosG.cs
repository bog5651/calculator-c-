using System;

namespace calcularot.OneArgumentClass
{
    public class CosG : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Cos(firstVlue * (180 / Math.PI));
        }
    }
}
