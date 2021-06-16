using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4PO2
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroComplexo c1 = new NumeroComplexo(5,3);
            NumeroComplexo c2 = new NumeroComplexo(-2, 4);

            Console.WriteLine(c1 + " + " + c2 + " = " + (c1 + c2));
            Console.WriteLine(c1 + " + " + c2 + " = " + (c1 - c2));
            Console.WriteLine(c1 + " + " + c2 + " = " + (c1 * c2));

        }
    }
}
