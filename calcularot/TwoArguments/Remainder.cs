namespace calcularot.TwoArguments
{
    public class Remainder : ITwoArgumentsCalculation
    {
        public double Calculate(double firstVlue, double secondValue)
        {
            return firstVlue % secondValue;
        }
    }
}
