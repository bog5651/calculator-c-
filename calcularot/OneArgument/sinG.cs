using System;

namespace calcularot.OneArgument
{
    public class SinG : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Sin(firstVlue * (180 / Math.PI));
        }
    }
}
