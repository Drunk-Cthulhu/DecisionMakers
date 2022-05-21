using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderGrad
{
    internal class Setup
    {
        public double step = 0.4;
        public double[] start = { 1, 1 };
        public double GetFunction(double x1, double x2)
        {
            return (Math.Pow(x1, 2) + x1 * x2 + 2 * Math.Pow(x2, 2) - 7 * x1 - 7 * x2);
        }
        public double[] GetGrad(double[] x)
        {
            double[] result = { 2*x[0]+x[1]-7 , x[0]+4*x[1]-7 };
            return (result);
        }
    }
}
