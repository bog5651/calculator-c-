﻿namespace calcularot.MathFunction_factory_and_intarface
{
    public class Substraction:ITwoArgumentsCalculation
    {
        public double Calculate(double firstVlue, double secondValue)
        {
            return firstVlue - secondValue;
        }
    }
}
