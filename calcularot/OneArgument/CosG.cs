using System;

namespace calcularot.OneArgument
{
    /// <summary>
    /// Class the calculating number Cosinus in Gradus
    /// </summary>
    public class CosG : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Cos(firstVlue * (180 / Math.PI));
        }
    }
}
