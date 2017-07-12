﻿using System;

namespace calcularot.TwoArguments
{
    public class Geometricmean : ITwoArgumentsCalculation
    {
        public double Calculate(double firstVlue, double secondValue)
        {
            return Math.Sqrt(firstVlue * secondValue);
        }
    }
}
