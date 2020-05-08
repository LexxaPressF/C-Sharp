using System;
using System.Collections.Generic;
using System.Text;

namespace casino_v2._0
{
    class Game
    {
        //Свойства
        public char choice_cont; //Выбор продолжительности игры 
        public Player player = new Player();
        //Методы
        public void Start()
        {
            do if (Bet() == true) player.capital += money_bet; else capital -= money_bet;
            while (choice_cont == 'y' && capital > 0);
            End();
        }
        bool Bet()
        {
            odd = rnd_numb.Next(0, 666) % 2; //Изменение случайного числа
            Console.WriteLine("У вас есть " + capital + "$\nСколько поставите?");
            money_bet = float.Parse(Console.ReadLine());
            while (money_bet > capital)
            {
                Console.WriteLine("Введите ставку не превыщающую размер вашего капитала: ");
                money_bet = float.Parse(Console.ReadLine());
            }
            while (money_bet <= 0)
            {
                Console.WriteLine("Введите положительную ставку: ");
                money_bet = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("На что поставите? (четное - 0; нечетное - 1)");
        Point:
            choice = int.Parse(Console.ReadLine());
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
    }
}
