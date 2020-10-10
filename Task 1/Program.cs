using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a, b;
            Console.Write("Введіть a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ввeдіть b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Периметр = {a + a + b + b}");
            Console.WriteLine($"Площа = {a * b}");
        }
    }
}
