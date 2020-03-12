using System;
using System.Collections.Generic;
using System.Text;

namespace Utils
{
    class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static bool Factorial(int n, out int answer)
        {
            int k; //Счетчик итераций
            int f = 1; //Рабочее значение
            bool ok = true; //Успешность операции
            try
            {
                checked    //Проверка на арифметическое переполнение в юлоке 
                {
                    for (k = 2; k <= n; ++k) // Цикл факториала
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception) // Обработчик исключительных ситуаций 
            {
                f = 0; //Если что-то пошло не так
                ok = false;// То получаем отрицательное значение в проверке
            }
            answer = f;
            return ok;
        }
    }
}
