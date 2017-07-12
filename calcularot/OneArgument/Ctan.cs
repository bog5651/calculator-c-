using System;

namespace calcularot.OneArgument
{
    public class Ctan : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Tan(1 / Math.Tan(firstVlue));
        }
    }
}
