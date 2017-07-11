using System;

namespace calcularot.OneArgumentClass
{
    public class Ln : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Log(firstVlue,Math.E);
        }
    }
}
