using System;
namespace calcularot
{
    public class RadinGrad : MathFunction_factory_and_intarface.IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return firstVlue * Math.PI / 180;
        }
    }
}
