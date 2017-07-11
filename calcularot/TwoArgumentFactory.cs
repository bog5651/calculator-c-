using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcularot
{
    public static class TwoArgumentFactory
    {
        public static ITwoArgumentsCalculation CreatCalculation(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Plus":
                    return new Addition();
                case "Minus":
                    return new Substraction();
                case "Multiplire":
                    return new Multiplication();
                case "Division":
                    return new Division();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
