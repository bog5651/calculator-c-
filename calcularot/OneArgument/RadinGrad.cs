using System;

namespace calcularot.OneArgument
{
    /// <summary>
    /// The class transferring radians to degrees
    /// </summary>
    public class RadinGrad : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return firstVlue * Math.PI / 180;
        }
    }
}
