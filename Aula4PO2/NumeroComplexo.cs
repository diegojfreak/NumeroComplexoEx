using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4PO2
{
    class NumeroComplexo
    {
        public double Real { get; set; }
        public double Imaginario { get; set; }

        public NumeroComplexo(double real, double imag)
        {
            Real = real;
            Imaginario = imag;
        }
        public static NumeroComplexo operator + (NumeroComplexo c1, NumeroComplexo c2)
        {
            return new NumeroComplexo(c1.Real + c2.Real, c2.Imaginario + c2.Imaginario);
        }

        public static NumeroComplexo operator - (NumeroComplexo c1, NumeroComplexo c2)
        {
            return new NumeroComplexo(c1.Real - c2.Real, c2.Imaginario - c2.Imaginario);
        }

        public static NumeroComplexo operator * (NumeroComplexo c1, NumeroComplexo c2)
        {
            double real = 0;
            double imag = 0;

            real = c1.Real * c2.Real - c1.Imaginario * c2.Imaginario;
            imag = c1.Real * c2.Imaginario + c1.Imaginario * c2.Real;

            return new NumeroComplexo(real, imag);
        }

        public override string ToString()
        {
            if (Imaginario >= 0)
                return Real + " + " + Imaginario + "i";
            else
                return Real + " - " + Math.Abs(Imaginario) + "i";
           
        }
    }
}
