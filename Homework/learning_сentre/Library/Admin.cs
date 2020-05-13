using System;
using System.Collections.Generic;
using System.Text;

namespace learning_сentre
{
    public class Admin: Person
    {
        public string laba;//Лабараторная

        //Конструктор
        public Admin(): base()
        {
            Console.Write("Введите название лабаратории: ");
            this.laba = Console.ReadLine();
        }

        //Методы
        virtual public void Show()
        {
            Console.WriteLine("----------------------Админ----------------------");
            base.Show();
            Console.WriteLine("Лабаратория: " + this.laba);
        }
    }
}
