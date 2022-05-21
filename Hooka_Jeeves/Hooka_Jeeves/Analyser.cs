using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hookah_Jeeves
{
   
    internal static class Analyser
    {
        static double gX1;
        static double gX2;
        static double step;
        static double DoTheThing(Setup setup, double baseFunction, double startX1, double startX2)
        {
            
            double x1 = startX1;
            double x2 = startX2;
            
            double stepRedux = setup.stepRedux;
            double oldFunction = baseFunction;
            double newFunction = setup.GetFunction(x1 + step, x2);
            Console.WriteLine($"x1 = {x1}, x2 = {x2}, Fo = {oldFunction}, Fn = {newFunction}");
            //x1
            if (newFunction < oldFunction)
            {
                oldFunction = newFunction;
                x1 += step;
            }
            else
            {
                oldFunction = setup.GetFunction(x1 - step, x2);
                x1 -= step;    
            }
            if (oldFunction<baseFunction)
            {
                gX1 = x1;
                gX2 = x2;
            }
            
            //x2
            newFunction = setup.GetFunction(x1, x2 + step);
            Console.WriteLine($"x1 = {x1}, x2 = {x2}, Fo = {oldFunction}, Fn = {newFunction}");
            if (newFunction < oldFunction)
            {
                oldFunction = newFunction;
                x2 += step;
            }
            else
            {
                oldFunction = setup.GetFunction(x1, x2 - step);
                x2 -= step;
            }
            if (oldFunction<baseFunction)
            {
                gX1 = x1;
                gX2 = x2;
            }
            Console.WriteLine($"x1 = {gX1}, x2 = {gX2}, Fo = {oldFunction}, Fn = {newFunction}");
            //по образцу
            if (oldFunction < baseFunction)
            {
                newFunction = setup.GetFunction(x1 + setup.exMul*(x1 - startX1), x2 + setup.exMul * (x2 - startX2));
                if (newFunction<oldFunction)
                {
                    oldFunction = newFunction;
                    x1 += setup.exMul * (x1 - startX1);
                    x2 += setup.exMul * (x2 - startX2);
                }
                
                gX1 = x1;
                gX2 = x2;
                Console.WriteLine($"x1 = {gX1}, x2 = {gX2}, Fo = {oldFunction}, Fn = {newFunction}");
                return (oldFunction);
            }
            else
            {
                oldFunction = baseFunction;
                step /= setup.stepRedux;
                return oldFunction;
            }
            

        }
        public static double HookeJeeves(Setup setup)
        {
            double baseFunction = setup.GetFunction(setup.start[0], setup.start[1]);
            step = setup.step;
            gX1 = setup.start[0];
            gX2 = setup.start[1];
            int i = 0;
            while (step>0.01)
            {
                Console.WriteLine(++i);
                baseFunction = DoTheThing(setup, baseFunction, gX1, gX2);

            }
            return (baseFunction);
        }

    }
}
