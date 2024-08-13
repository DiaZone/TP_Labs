using System;
using System.Windows;

namespace TPLaba3
{
    static class Program
    {
        static void Main()
        {
            Equ Resh = new Equ();
            double x0, x, h, k;
            Console.WriteLine("Введите x0: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите кол-во точек: ");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг: ");
            h = Convert.ToDouble(Console.ReadLine());
            double xk = x + (h * k);
            double F;
            int count = 0;
            while (x <= xk)
            {
                try
                {
                    F = Resh.F1(x) + Resh.F2(x) + Resh.F3(x) + Resh.F4(x);
                    x += h;
                    Console.WriteLine(F);
                }
                catch (NotFiniteNumberException)
                {
                    Console.WriteLine("Error");
                    x += h;
                    count++;
                }
                if(count == 1)
                {
                    System.Windows.MessageBox.Show("Ошибка в расчетах","Ошибка");
                    count++;
                }
            }
            Console.WriteLine("{0} - количество ошибок ", --count);
        }
    }
}