using System;

namespace calcularot.OneArgument
{
    /// <summary>
    /// Class the calculating number cosinus
    /// </summary>
    public class Cos : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Cos(firstVlue);
        }
    }
}
