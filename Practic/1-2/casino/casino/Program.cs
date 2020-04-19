using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace casino
{
    class Program
    {
        static void Main()
        {
            float capital; //Баланс пользователя
            int choice; //Выбор пользователя
            bool result; //Успешность ставки
            Random rnd_numb = new Random();
            int odd = rnd_numb.Next(0, 666)%2; //Четность случайного числа
            void Play()
            {
                Console.WriteLine("Добро пожаловать в Казино");
                Console.WriteLine("Введите ваш начальный капитал: ");
                capital = float.Parse(Console.ReadLine());
                if (Bet() == true) 
            };
            bool Bet()
            {
                Console.WriteLine("У вас есть " + capital + "$\nНа что поставите? (четное - 0; нечетное - 1");
                choice = int.Parse(Console.ReadLine());
                Point:
                switch (choice)
                {
                    case 0: Console.WriteLine("Ваш выбор: четное"); break;
                    case 1: Console.WriteLine("Ваш выбор: нечетное"); break;
                    default: Console.WriteLine("ВВедите верное значение"); goto Point; break;
                };
                if (odd == choice) result = true; else result = false;
                return result;
            }
        }
    }
}
