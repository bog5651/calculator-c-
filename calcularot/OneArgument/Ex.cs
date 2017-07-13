using System;

namespace calcularot.OneArgument
{
    /// <summary>
    /// Class the calculating e^x
    /// </summary>
    public class Ex : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Pow(Math.E,firstVlue);
        }
    }
}
