using System;
using System.Collections.Generic;
using System.Text;

namespace learning_сentre
{
    public class Manager: Person
    {
        public string department; //Факультет
        private string position; //Должность 
        public int exp; //Стаж
        private double salary; //Зар. плата

        //Конструктор
        public Manager() : base()
        {
            Console.Write("Введите название факультета: "); 
            this.department = Console.ReadLine();
            Console.Write("Введите ваш трудовой стаж: ");
            this.exp = int.Parse(Console.ReadLine());
            this.salary = Calc_salary();
        }
        //Метод
        virtual public void Show()
        {
            Console.WriteLine("----------------------Менеджер----------------------");
            base.Show();
            Console.WriteLine("Факультет: " + this.department);
            Console.WriteLine("Стаж: " + this.exp);
        }
        private double Calc_salary()
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
