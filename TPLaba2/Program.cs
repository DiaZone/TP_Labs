using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLaba2
{
    static class Program
    {
        public static string name = "этилбензол";
        const string version = "1.01";
        const string DateOfChange = "24.02.2022";
        static void Main(string[] args)
        {
            Class1 Resh = new Class1();
            for (int i = 50; i<=200; i += 10) {
                double znach = Resh.OpPvp(Resh.T + i) *760;
                Console.WriteLine("Значение давления {2}а при температуре в {0:0.###} °С равна {1:0.###}", i, znach, name);
            }
            double t1 = 74.1;
            double x1 = Resh.OpPvp(t1 + Resh.T)*760;
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("Значение давления {2}а при температуре в {0:0.###} °С равна {1:0.###}", t1, x1, name);
            double pog1 = Math.Abs((x1-100)/100)*100;
            Console.WriteLine("Относительная погрешность равна {0:0.##}%", pog1);
            double t2 = 186.8;
            double x2 = Resh.OpPvp(t2 + Resh.T) * 760;
            Console.WriteLine("\n\nЗначение давления {2}а при температуре в {0:0.###} °С равна {1:0.###}", t2, x2, name);
            double pog2 = Math.Abs((x2 - 2494) / 2494)*100;
            Console.WriteLine("Относительная погрешность равна {0:0.##}%", pog2);
            Console.WriteLine("\n------------------------------------------------------------");
            Console.WriteLine("|Версия программы - {0} | Дата редактирования - {1}|", version, DateOfChange);
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}