using System;

namespace calcularot.OneArgument
{
    public class Tan : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Tan(firstVlue);
        }
    }
}
