using System;
using System.IO;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace casino_v2._0
{
    class Player
    {
        //Свойства
        public int bet_count = 0; //Кол-во ставок в 1 игре
        public float capital; //Капитал
        public int choice; //Выбор игрока (чет/нечет)
        public string name; // Имя игрока

        //Конструктор
        public Player()
        {
            Console.WriteLine("Добро пожаловать в Казино");
            Console.Write("Введите ваше имя: ");
            this.name = Console.ReadLine();
            Console.Write("Введите ваш начальный капитал: ");
            this.capital = float.Parse(Console.ReadLine());
        }
        //Методы
        public void Get_info()
        {//Геттер + запись в файл
            Console.WriteLine("Имя: " + this.name + "\nКол-во сыгранных ставок: " + this.bet_count
                + "\nКонечный капитал: " + this.capital);
            //запись данных в файл по завершении игры
            string text = "---------------------------\nИгрок: " + name + "\nКол-во ставок: " + this.bet_count + 
                "\nКонечный баланс: " + this.capital + "\n---------------------------";
            StreamWriter sw = new StreamWriter("Все_игры.txt", true);
            sw.WriteLine(text);
            sw.Close();
        }
    }
}
