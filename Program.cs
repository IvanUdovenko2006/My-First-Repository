using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Четырехзначные числа, удовлетворяющие условиям:");
            for (int i = 1000; i <= 9999; i++)
            {
                if (i % 133 == 125 && i % 134 == 111)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Поиск успешно завершен.");
            Console.ReadKey();
        }
    }
}
