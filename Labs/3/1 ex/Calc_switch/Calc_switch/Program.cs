using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_switch
{
    class Program
    {
        static void Main()
        {
            Console.Write("A = ");
            double a = double.Parse(Console.ReadLine());//Получение 1-го операнда
            Console.Write("OP = ");
            char op = char.Parse(Console.ReadLine());   //Получение знака операции
            Console.Write("B = ");
            double b = double.Parse(Console.ReadLine());//Получение 2-го операнда
            bool ok = true;//Для дальнейшей проверки
            double res = 0;//Результат операции
            switch (op) //Условный оператор и выражение соответствия
            {
                case '+': res = a + b; //Если переменная op = +, то выполняется этот случай
                break; //Оператор остановки
                case '-': res = a - b; break;
                case '*': res = a * b; break;
                case '/':
                case ':': res = a / b; break;
                default: ok = false; break; //Если польз. ввел другое значение переменная изменится
            }
            if (ok) Console.WriteLine("{0} {1} {2} = {3}", a, op, b, res);//Вывод если все хорошо
            else Console.WriteLine("Операция не определена");//Вывод ошибки
        }
    }
}
