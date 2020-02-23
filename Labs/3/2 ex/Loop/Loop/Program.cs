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
            //Постусловие
            Console.WriteLine("------Постусловие------");
            double x, x1, x2, y; //Аргументы
            Console.Write("Введите аргумент x1: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите аргумент x2: ");
            x2 = double.Parse(Console.ReadLine());  //Получение аргументов
            Console.Write("Sin(x)");
            x = x1;
            do                      //Вначале действие
            {
                y = Math.Sin(x);
                Console.WriteLine("\t{0}", y);
                x = x + 0.01;
            }
            while (x <= x2); //Условие продолжения
            Console.Write("\n");
            //Предусловие
            Console.WriteLine("------Предусловие------");
            double temp, a, b; //Аргументы
            string temp1; //Для хранения измененых данных
            Console.Write("Введите аргумент a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите аргумент b: ");
            b = double.Parse(Console.ReadLine());  //Получение аргументов
            temp1 = a + " и " + b;
            temp = a;
            while (temp != b)  //Условие начала и продолжения
            {                  //Действие
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            Console.WriteLine("НОД от {0} = {1}", temp1, a);
        }
    }
}
