using System;
namespace ConsoleWhile
{
    class Program
    {
        static void Main()
        {
            double a = 0, e = 0.0001, q = 0, s = 0, x = 0.12;
            int n = 0;
            a = x; // Инициализация цикла
            s = a;
            while (Math.Abs(a) > e) // Цикл
            {
                q = (x / (n + 1) * (n + 2)) * Math.Cos((Math.PI / 4) * n);
                a *= q;
                s += a;
                n++;
            }
            Console.WriteLine();
            Console.WriteLine("Результат");
            Console.WriteLine();
            Console.WriteLine("Сумма s=" + Convert.ToString(s));
            Console.WriteLine("Число членов ряда n=" + Convert.ToString(n));
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
