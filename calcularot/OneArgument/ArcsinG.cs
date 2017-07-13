using System;

namespace calcularot.OneArgument
{   /// <summary>
    /// Class the calculating number arcsine in Gradus
    /// </summary>
    public class ArcsinG : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Asin(firstVlue);
        }
    }
}
