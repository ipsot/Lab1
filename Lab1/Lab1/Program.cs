using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double x, y;
            double a, b, p;
            Console.WriteLine("Введите шаг");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введите помежуток");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());

            x = a;
            do
            {
                if (x < -2)
                {
                    y = 5 + ( Math.Log10(3 * x)) ;
                }
                else if (x>-2 && x<=2)
                {
                    y = (Math.Cos(x) - Math.Sin(x)) ;
                }
                else
                {
                    y = Math.Abs(4 - 2 * Math.Pow(x, 5)) - Math.Sqrt(2 * x);

                }
                Console.WriteLine($"x={x}; f(x)={y}");
                x += p;

            }
            while (x <= b + p);

            Console.ReadKey();

        }
    }
}
