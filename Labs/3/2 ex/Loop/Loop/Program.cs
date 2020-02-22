using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main()
        {
            /*Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            // while:
            Console.Write("\nwhile: \t\t");
            int i = 1;
            while (i <= n)
            {
             Console.Write(" " + i);
                i += 2;
            }
            // do while:
            Console.Write("\ndo while: \t");
            i = 1;
            do
            {
                Console.Write(" " + i);
                i += 2;
            }
            while (i <= n);
            // for:
            Console.Write("\nFor: \t\t");
            for (i = 1; i <= n; i += 2)
            {
                Console.Write(" " + i);
            }
            */
            double x, x1, x2, y; //Аргументы
            Console.Write("Введите аргумент x1: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите аргумент x2: ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("Sin(x)");
            x = x1;
            do
            {
                y = Math.Sin(x);
                Console.Write("\t" + y + " ");
                x = x + 0.01;
            }
            while (x <= x2);
        }
    }
}
