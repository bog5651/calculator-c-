using System;

namespace calcularot.OneArgument
{   /// <summary>
    /// Class the calculating number arcsine
    /// </summary>
    public class Arcsin : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Asin(firstVlue);
        }
    }
}
