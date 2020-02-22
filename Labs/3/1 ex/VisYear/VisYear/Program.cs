using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisYear
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите номер года: ");
            int y = int.Parse(Console.ReadLine()); //Получаем номер года
            if ((y % 4 == 0) && (y % 100 != 0) | (y % 400 == 0)) //Условие високостности
                Console.WriteLine("Год является високосным"); //Сообщение если да
            else Console.WriteLine("Год не является високосным"); //Сообщение если нет
        }
    }
}



