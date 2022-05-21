using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderGrad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Setup setup = new Setup();
            Console.WriteLine(Analyser.Minimize(setup));
            Console.WriteLine(Analyser.Minimize(setup));
        }
    }
}
