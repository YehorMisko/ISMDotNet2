using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double a, b, c, x, d;
            Console.Write("Введіть a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Ввeдіть b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Ввeдіть c = ");
            c = double.Parse(Console.ReadLine());
            d = b * b - 4 * a * c;
            Console.WriteLine($"Дискримінант = {d}");
            if (a == 0) Console.WriteLine("Рівняння Лінійне");
            else
            {
                if (d < 0)
                {
                    Console.WriteLine("Розв'язків немає");
                }
                if (d > 0)
                {
                    x = ((-b + Math.Sqrt(d)) / (2 * a));
                    Console.WriteLine($"x1 = {x}");
                    x = ((-b - Math.Sqrt(d)) / (2 * a));
                    Console.WriteLine($"x2 = {x}");
                }
                if (d == 0)
                {
                    x = ((-b) / (2 * a));
                    Console.WriteLine($"x = {x}");
                }
            }
        }
    }
}
