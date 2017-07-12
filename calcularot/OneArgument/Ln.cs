using System;

namespace calcularot.OneArgument
{
    public class Ln : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Log(firstVlue,Math.E);
        }
    }
}
