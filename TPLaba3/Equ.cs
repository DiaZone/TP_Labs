using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLaba3
{
    internal class Equ
    {
        public double F1(double x)
        {
            if (x<0)
            {
                throw new NotFiniteNumberException();
            }
            return Math.Pow(Math.Pow(x, 3 / 2) - 2, 1 / 3);
        }

        public double F2(double x)
        {
            return Math.Cos(-Math.Pow(x, 2));
        }

        public double F3(double x)
        {
            if (x == 0)
            {
                throw new NotFiniteNumberException();
            }
            return Math.Cosh(Math.Pow(2/x, 1/3));
        }

        public double F4(double x)
        {
            double sumF4 = 0;
            for(int i = 1; i<=1000000; i++) {
               sumF4 += (i * x * x - 1) * Math.Sqrt(x);
            }
            return sumF4;
        }
    }
}
