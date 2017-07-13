using System;

namespace calcularot.OneArgument
{   /// <summary>
    /// Class the calculating number arccosine
    /// </summary>
    public class Arccos : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Acos(firstVlue);
        }
    }
}
