using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int n;
            Console.Write("Введіть n = ");
            n = int.Parse(Console.ReadLine());
            double q = 0;
            for(int i = 1; i <= n; i++ )
            {
                q += (1.0 / i);
            }
            Console.WriteLine($"Відповідь = {q}");
        }
    }
}
