using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularot.MathFunction_factory_and_intarface
{
    public class CosG : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Cos(firstVlue * (180 / Math.PI));
        }
    }
}
