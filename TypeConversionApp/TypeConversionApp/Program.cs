using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversionApp
{
    class ExplicitConversion
    {
        static void Main(string[] args)
        {
            double d = 5673.74;
            int i;

            // Cast double to int
            i = (int)d;
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
