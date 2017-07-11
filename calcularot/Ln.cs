using System;

namespace calcularot
{
    public class Ln : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Log(firstVlue,Math.E);
        }
    }
}
