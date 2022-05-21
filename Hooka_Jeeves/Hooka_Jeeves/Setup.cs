using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hookah_Jeeves
{
    internal class Setup
    {
        public double GetFunction(double x1, double x2) 
        {
            return (Math.Pow(x1, 2) + x1*x2 + 2*Math.Pow(x2, 2) - 7*x1 - 7*x2);
        }
        public double step = 0.2;
        public double stepRedux = 2;
        public double[] start = { 1, 1 };
        public int exMul = 1;
    }
}
