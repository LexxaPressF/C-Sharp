using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equation
{
    class Program
    {
        static void Main()
        {
            try
            {
            double a, b, c; //Коэфиценты
            double x1 = 0, x2 = 0; //Корни
            int ans; //Возвращаемое значение
            Console.WriteLine("Уравнение вида: ax^2+bx+c; \nВведите коэфиценты");
            Console.Write("а = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());
            ans = Methods.Equation(a, b, c, ref x1, ref x2);
            if (ans == -1)
                Console.WriteLine("Дискриминант отрицательный\nВозвращаемое значение: " + ans);
            else
                Console.WriteLine(a + "*x^2+(" + b + ")*x+(" + c + ") Имеет корни:\nx1 = " +
                    x1 + "\nx2 = " + x2 + "\nВозвращаемое значение: " + ans);
            }
            catch(Exception e)
            {
                Console.WriteLine("Ошибка" + e);
            }
            

        }
    }
}
