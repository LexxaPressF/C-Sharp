using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    interface Progression
    {
        /*Свойства - в интнрфейсе только константы
        public double a0; //Первый элемент
        public double n; //Количество элементов
        Конструкторы - недопустимы в интерфейсе
        public Progression(double a, double b)
        {
            this.a0 = a;
            this.n = b;
        }
        public Progression()
        {
            Console.Write("Введите первый элемент: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите кол-во элементов: ");
            double b = double.Parse(Console.ReadLine());
            this.a0 = a;
            this.n = b;
        }*/
        //Методы
        double GetElement(int k);
        void Print();
        /*{
            Console.WriteLine("================Прогрессия" +
                "================");
            Console.WriteLine("Кол-во элементов: " + this.n);
            Console.WriteLine("Первый элемент: " + this.a0);
        }*/
    }
}
