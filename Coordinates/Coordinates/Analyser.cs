using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderGrad
{
    internal static class Analyser
    {
        public static double Minimize(Setup setup)
        {
            double step = setup.step;
            double[] x0 = setup.start;
            double result = setup.GetFunction(x0[0], x0[1]);
            double[] x1 = Search(setup, x0, step);
            while(Math.Abs(setup.GetGrad(x1)[0]+ setup.GetGrad(x1)[1])>0.00001)
            {
                x1 = Search(setup, x0, step);
                if (setup.GetFunction(x1[0], x1[1]) < result)
                {
                    result = setup.GetFunction(x1[0], x1[1]);
                    x0 = x1;
                }
                else
                {
                    step /= 2;
                }
                Console.WriteLine(result);
            }
            
            return result;
        }
        static double[] Search(Setup setup, double[] x0, double step)
        {
            
            double[] gradientVector = setup.GetGrad(x0);
            double[] x1 = { x0[0] - step * gradientVector[0], x0[1] - step * gradientVector[1] };
            Console.WriteLine($"x0({x0[0]} , {x0[1]})  x0({x1[0]} , {x1[1]}) \n Gradient({gradientVector[0]},{gradientVector[1]})");
            return x1;
        }
    }
}
