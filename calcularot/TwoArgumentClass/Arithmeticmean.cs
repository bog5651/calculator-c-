﻿namespace calcularot.TwoArgumentClass
{
    public class Arithmeticmean : ITwoArgumentsCalculation
    {
        public double Calculate(double firstVlue, double secondValue)
        {
            return (firstVlue + secondValue) / 2;
        }
    }
}
