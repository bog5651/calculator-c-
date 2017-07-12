using System;

namespace calcularot.OneArgument
{
    public class CosG : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Cos(firstVlue * (180 / Math.PI));
        }
    }
}
