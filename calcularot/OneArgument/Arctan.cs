using System;

namespace calcularot.OneArgument
{
    /// <summary>
    /// Class the calculating number arcTan
    /// </summary>
    public class Arctan : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Atan(firstVlue);
        }
    }
}
