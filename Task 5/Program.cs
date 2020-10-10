using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Введіть день тижня числом = ");
            byte a;
            a = byte.Parse(Console.ReadLine());
            switch(a)
            {
                case 1:
                    Console.WriteLine("Понеділок");
                    break;
                case 2:
                    Console.WriteLine("Вівторок");
                    break;
                case 3:
                    Console.WriteLine("Середа");
                    break;
                case 4:
                    Console.WriteLine("Четвер");
                    break;
                case 5:
                    Console.WriteLine("П'ятниця");
                    break;
                case 6:
                    Console.WriteLine("Субота");
                    break;
                case 7:
                    Console.WriteLine("Неділя");
                    break;
                default:
                    Console.WriteLine("Помилка");
                    break;
            }
        }
    }
}
