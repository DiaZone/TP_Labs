using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLaba2
{
    internal class Class1
    {
        public double T = 273.15;
        private readonly double Tc = 617.7;
        private readonly double Pc = 35.6;

        public double OpTr(double T)
        {
            double Tr = T / Tc;
            return Tr;
        }

        public double EquationRidle(double T)
        {
            double Pvpr = Math.Exp(-(3.720 / OpTr(T)) * (1 - (OpTr(T) * OpTr(T)) + 0.544 * (3 + OpTr(T)) * Math.Pow((1 - OpTr(T)), 3)));
            return Pvpr;
        }
        public double OpPvp(double T)
        {
            double Pvp = EquationRidle(T) * Pc;
            return Pvp;
        }
    }
}
