using System;
using System.Collections.Generic;
using System.Text;

namespace learning_сentre
{
    class Professor: Person, IEmployee
    {
        public string department; //Факультет
        public int exp; //Стаж
        private double salary; //Зар. плата


        //Конструктор
        public Professor() : base()
        {
            Console.Write("Введите название факультета: ");
            this.department = Console.ReadLine();
            Console.Write("Введите ваш трудовой стаж: ");
            this.exp = int.Parse(Console.ReadLine());
            this.salary = Calc_salary();
        }

        //Методы
        virtual public void Show()
        {
            Console.WriteLine("----------------------Преподаватель----------------------");
            base.Show();
            Console.WriteLine("Факультет: " + this.department);
            Console.WriteLine("Стаж: " + this.exp);
        }
        public void Teach()
        {
            Random rnd = new Random();
            int r1 = rnd.Next(0, 1000);
            int r2 = rnd.Next(0, 1000);
            Console.Write("Вот вам задачка надом:");
            Console.WriteLine("{0} + {1}", r1, r2);
        }
        public double Calc_salary()
        {
            double base_salary = 50000;//₽ Стандартная зар. плата
            if (this.exp > 5) return base_salary * 1.2;
            else if (this.exp > 10) return base_salary * 1.5;
            else if (this.exp > 15) return base_salary * 1.7;
            else if (this.exp > 20) return base_salary * 2;
            else return base_salary;
        }
    }
}
