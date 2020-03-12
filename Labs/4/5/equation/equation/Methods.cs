using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equation
{
    class Methods
    {
        public static int Equation(double a, double b, double c, ref double x1, ref double x2)
        {
            double D; //Дискриминант
            int answer; //Возвращаемое значение
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D == 0) //Проверка дискриминанта
                answer = 0;
            else if (D < 0)
                return -1;
            else answer = 1;
            x1 = (-b + Math.Sqrt(D)) / (2 * a); //Вычисление корней
            x2 = (-b - Math.Sqrt(D)) / (2 * a);
            return answer;
        }
    }
}
