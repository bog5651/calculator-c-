﻿namespace calcularot.TwoArguments
{
    public class Addition : ITwoArgumentsCalculation
    {
        public double Calculate(double firstVlue, double secondValue)
        {
            return firstVlue + secondValue;
        }
    }
}
