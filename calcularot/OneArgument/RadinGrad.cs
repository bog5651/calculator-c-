using System;

namespace calcularot.OneArgument
{
    public class RadinGrad : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return firstVlue * Math.PI / 180;
        }
    }
}
