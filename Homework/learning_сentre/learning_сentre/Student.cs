using System;
using System.Collections.Generic;
using System.Text;

namespace learning_сentre
{
    public class Student: Person
    {
        public string department; //Факультет
        public string group; //Группа

        //Конструктор
        public Student():base()
        {
            Console.Write("Введите название факультета: ");
            this.department = Console.ReadLine();
            Console.Write("Введите название группы: ");
            this.group = Console.ReadLine();
        }

        //Методы
        virtual public void Show()
        {
            Console.WriteLine("----------------------Студент----------------------");
            base.Show();
            Console.WriteLine("Факультет: " + this.department);
            Console.WriteLine("Группа: " + this.group);
        }

        private void Study()
        {
            Random rnd = new Random();
            int r1 = rnd.Next(0, 1000);
            int r2 = rnd.Next(0, 1000);
            Console.WriteLine("Эврика!");
            Console.WriteLine("{0} + {1} = {2}", r1, r2, r1 + r2);
        }
    }
}
