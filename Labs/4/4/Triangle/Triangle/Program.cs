using System;

namespace Triangle
{
    class Program
    {
        static void Main()
        {
            try
            {
                double a, b, c; //Стороны треугольника
                double s; // Площадь
                Console.WriteLine("Введите значения сторон треугольника:");
                Console.Write("а = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                c = double.Parse(Console.ReadLine());
                if (a == b && b == c)
                    s = Methods.Area(ref a);
                else
                    s = Methods.Area(ref a, ref b, ref c);
                Console.WriteLine("Площадь введеного треугольника:  {0:0.00}", s);
            }
            catch(Exception e)
            {
                Console.WriteLine("Ошибка " + e);
            }
        }
    }
}
