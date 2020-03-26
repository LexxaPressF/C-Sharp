using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    class GeometricProgression : Progression
    {
        //Свойства
        public double a0; //Первый элемент
        public double n; //Количество элементов
        public double q; //Частное соседних элементов
        public double p; //Произведение прогрессии
        //Конструкторы
        public GeometricProgression(double a, double b,
            double q)
        {
            this.a0 = a;this.n = b;
            this.q = q; this.p = Proiz(this);
        }
        public GeometricProgression() : base()
        {
            Console.Write("Введите первый элемент: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите кол-во элементов: ");
            double b = double.Parse(Console.ReadLine());
            this.a0 = a;this.n = b;
            Console.Write("Введите частное между элементами: ");
            this.q = double.Parse(Console.ReadLine());
            this.p = Proiz(this);
        }
        //Методы
        public void Print()
        {
            Console.WriteLine("================Прогрессия" +
                "================");
            Console.WriteLine("Кол-во элементов: " + this.n);
            Console.WriteLine("Первый элемент: " + this.a0);
            Console.WriteLine("Частное соседних элементов: " + this.q);
            Console.WriteLine("Произведение элементов: " + this.p);
            Console.WriteLine("================================");
        }
        private double Proiz(GeometricProgression a)
        {
            double p = Math.Pow((Math.Pow(a.a0, 2)*
                Math.Pow(a.q, a.n-1)),n/2);
            return p;
        }
        public double GetElement(int k)
        {
            double a = this.a0 * Math.Pow(this.q, k-1);
            return a;
        }
    }
}
