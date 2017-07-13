using System;

namespace calcularot.OneArgument
{   /// <summary>
    /// Class the calculating number module
    /// </summary>
    public class Abs : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Abs(firstVlue);
        }
    }
}
