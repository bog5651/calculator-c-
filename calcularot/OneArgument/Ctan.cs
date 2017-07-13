using System;

namespace calcularot.OneArgument
{
    /// <summary>
    /// Class the calculating number Cotangens
    /// </summary>
    public class Ctan : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Tan(1 / Math.Tan(firstVlue));
        }
    }
}
