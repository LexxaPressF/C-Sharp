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
            int choice; //Выбор ставки пользователя 
            char choice_cont; //Выбор продолжительности игры
            float money_bet; //Размер денежной ставки
            bool result; //Успешность ставки
            Random rnd_numb = new Random();
            int odd; //Четность случайного числа
            void Play()
            {
                Console.WriteLine("Добро пожаловать в Казино");
                Console.Write("Введите ваш начальный капитал: ");
                capital = float.Parse(Console.ReadLine());
                do if (Bet() == true) capital += money_bet; else capital -= money_bet;
                while (choice_cont == 'y' && capital > 0);
                End();
            };
            bool Bet()
            {
                odd = rnd_numb.Next(0, 666) % 2; //Изменение случайного числа
                Console.WriteLine("У вас есть " + capital + "$\nСколько поставите?");
                money_bet = float.Parse(Console.ReadLine());
                Console.WriteLine("У вас есть " + capital + "$\nНа что поставите? (четное - 0; нечетное - 1)");
                choice = int.Parse(Console.ReadLine());
                Point:
                switch (choice)
                {
                    case 0: Console.WriteLine("Ваш выбор: " + money_bet + "$ на четное"); break;
                    case 1: Console.WriteLine("Ваш выбор: " + money_bet + "$ на нечетное"); break;
                    default: Console.WriteLine("ВВедите верное значение"); goto Point;
                };
                if (odd == choice)
                {
                    result = true;
                    Console.WriteLine("Ставка сыграла");
                }
                else
                {
                    result = false;
                    Console.WriteLine("Ставка не сыграла");
                }
                Console.WriteLine("Продолжаем? (y/n)");
                choice_cont = Char.Parse(Console.ReadLine());
                return result;
            }
            void End()
            {
                Console.WriteLine("Вы проиграли: ваш баланс = " + capital + "$");
                Console.WriteLine("Спасибо за игру");
            }
            Play();
        }
    }
}
