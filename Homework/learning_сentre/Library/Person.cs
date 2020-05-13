using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace learning_сentre
{
    public abstract class Person
    {
        public string FIO; //Фамилия, имя, отчество
        public DateTime birth; //Дата рождения
        public int age; //Возраст

        //Конструктор
        public Person()
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Введите фамилию, имя и отчество: ");
            this.FIO = Console.ReadLine();
            Console.Write("Введите дату вашего рождения (через точку): ");
            this.birth = DateTime.Parse(Console.ReadLine());
            DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            System.TimeSpan diff = today.Subtract(this.birth);
            this.age = diff.Days / 365;
        }

        //Метод
        virtual public void Show()
        {
            Console.WriteLine("---------------------Информация---------------------");
            Console.WriteLine("ФИО: " + this.FIO);
            Console.WriteLine("Дата рождения: " + this.birth.ToString("dd/MM/yyyy"));
            Console.WriteLine("Возраст: " + this.age);
        }
    }
}
