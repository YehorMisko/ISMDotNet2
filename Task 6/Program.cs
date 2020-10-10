using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
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
            long c = 1;
            for(int i = a;i <= b;i++ )
            {
                c *= i;
            }
            Console.WriteLine($"Добуток чисел від а до b = {c}");
        }
    }
}
