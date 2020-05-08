using System;
using System.Collections.Generic;
using System.Text;

namespace casino_v2._0
{
    class Game
    {
        //Свойства
        private float money_bet; //Размер денежной ставки
        private bool result; //Успешность ставки
        private Random rnd_numb = new Random();
        private int odd; //Четность случайного числа
        private char choice_cont; //Выбор продолжительности игры 
        public Player player = new Player();

        //Методы
        public void Start()
        {
            do if (Bet() == true) player.capital += money_bet; else player.capital -= money_bet;
            while (choice_cont == 'y' && player.capital > 0);
            player.Get_info();
        }
        bool Bet()
        {
            odd = rnd_numb.Next(0, 666) % 2; //Изменение случайного числа
            Console.WriteLine(player.name + ", вы имеете " + player.capital + "$\nСколько поставите?");
            money_bet = float.Parse(Console.ReadLine());
            while (money_bet > player.capital)
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
            player.choice = int.Parse(Console.ReadLine());
            switch (player.choice)
            {
                case 0: Console.WriteLine("Ваш выбор: " + money_bet + "$ на четное"); break;
                case 1: Console.WriteLine("Ваш выбор: " + money_bet + "$ на нечетное"); break;
                default: Console.WriteLine("ВВедите верное значение"); goto Point;
            };
            if (odd == player.choice)
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
