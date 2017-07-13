using System;

namespace calcularot.OneArgument
{   /// <summary>
    /// The class transferring degrees to radians
    /// </summary>
    public class GradinRad : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return firstVlue * 180 / Math.PI;
        }
    }
}
