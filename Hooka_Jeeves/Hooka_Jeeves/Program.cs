using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hookah_Jeeves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Setup setup = new Setup();
           
            Console.WriteLine($"{Analyser.HookeJeeves(setup)}");
            /*
            Console.WriteLine(setup.GetFunction(1, 1));
            Console.WriteLine(setup.GetFunction(1.2, 1));
            Console.WriteLine(setup.GetFunction(1.2, 1.2));
            Console.WriteLine(setup.GetFunction(1.6, 1.6));
            */
            Console.WriteLine(setup.GetFunction(2, 2));
        }
    }
}
