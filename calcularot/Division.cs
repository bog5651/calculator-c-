namespace calcularot
{
    public class Division : ITwoArgumentsCalculation
    {
        public double Calculate(double firstVlue, double secondValue)
        {
            return firstVlue / secondValue;
        }
    }
}
