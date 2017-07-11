using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularot
{
    public class x1 : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return 1/firstVlue;
        }
    }
}
