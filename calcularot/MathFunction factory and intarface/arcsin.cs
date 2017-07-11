using System;


namespace calcularot.MathFunction_factory_and_intarface
{
    public class ArcsinG : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Asin(firstVlue);
        }
    }
}
