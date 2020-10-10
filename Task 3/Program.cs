using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a, b, x;
            Console.Write("Введіть a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ввeдіть b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Ввeдіть x = ");
            x = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"y = {2.4 * Math.Abs((Math.Pow(x,2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b),2) + Math.Pow(10,-2) * (x - b)}");
        }
    }
}
