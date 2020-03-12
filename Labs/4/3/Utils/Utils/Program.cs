using System;

namespace Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int x;
               int y;
               Console.WriteLine("Введите первое число:");
               x = int.Parse(Console.ReadLine());
               Console.WriteLine("Введите второе число:");
               y = int.Parse(Console.ReadLine());
               int greater = Utils.Greater(x, y);
               Console.WriteLine("Большим из чисел {0} и {1} является {2} ", x, y, greater);
               Console.WriteLine("До swap: \t" + x + " " + y);
               Utils.Swap(ref x, ref y);
               Console.WriteLine("После swap: \t" + x + " " + y);
            */
            //Упражнение 3
            int f;
            bool ok;
            Console.WriteLine("Число для факториала:");
            int x = int.Parse(Console.ReadLine());
            //Проверка метода Factorial
            ok = Utils.Factorial(x, out f); //Вызов метода
            // Запись в переменную f значения answer внутри метода
            if (ok)
                Console.WriteLine(x + "! = " + f);
            else
                Console.WriteLine("Не хватает мщности чтобы сосчитать этот факториал");

        }
    }
}