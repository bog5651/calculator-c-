namespace calcularot.TwoArgumentClass
{
    public class Multiplication:ITwoArgumentsCalculation
    {
        public double Calculate(double firstVlue, double secondValue)
        {
            return firstVlue * secondValue;
        }
    }
}
