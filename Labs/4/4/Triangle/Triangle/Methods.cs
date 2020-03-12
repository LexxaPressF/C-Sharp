using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class Methods
    {
        private static bool Check(ref double a, ref double b, ref double c, out bool check)
        {
            bool ok;
            if (a + b < c | a + c < b | c + b < a)
                ok = false;
            else
                ok = true;
            check = ok;
            return ok;
        }
        public static double Area(ref double a, ref double b, ref double c)
        {
            bool check; // Переменная для проверки 
            Methods.Check(ref a, ref b, ref c, out check); // Проверка существования треугольника
            if (check == false)
            {
                Console.WriteLine("Такого треугольника не существует");
                return 0;
            }
            else
            {
                double s, p;   //Площадь и полупериметр
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }
        }
        public static double Area(ref double a)
        {
            double s, p;   //Площадь и полупериметр
            p = 3*a / 2;
            s = Math.Sqrt(p * Math.Pow((p - a), 3));
            return s;
        }
    }
}
