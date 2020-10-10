using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int n, a;
            Console.Write("Введіть a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введіть n = ");
            n = int.Parse(Console.ReadLine());
            int q = a;
            for (int i = 1; i < n; i++)
            {
                a *= q;
            }
            Console.WriteLine($"Відповідь = {a}");

        }
    }
}
