using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    class ArithmeticProgression : Progression
    {
        //Свойства
        public double a0; //Первый элемент
        public double n; //Количество элементов
        public double d; //Разность между элементами
        public double s; //Сумма прогрессии
        //Конструкторы
        public ArithmeticProgression(double a, double b, 
            double d)
        {
            this.a0 = a; this.n = b;
            this.d = d;this.s = Summa(this);
        }
        public ArithmeticProgression()
        {
            Console.Write("Введите первый элемент: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите кол-во элементов: ");
            double b = double.Parse(Console.ReadLine());
            this.a0 = a;this.n = b;
            Console.Write("Введите разность между элементами: ");
            double d = double.Parse(Console.ReadLine());
            this.d = d;
            this.s = Summa(this);
        }
        //Методы
        public void Print()
        {
            Console.WriteLine("================Прогрессия" +
                "================");
            Console.WriteLine("Кол-во элементов: " + this.n);
            Console.WriteLine("Первый элемент: " + this.a0);
            Console.WriteLine("Разность между элементами: "
                + this.d);
            Console.WriteLine("Сумма элементов: " + this.s);
            Console.WriteLine("================================");
        }
        private double Summa(ArithmeticProgression a)
        {
            double s = (2 * a.a0 + a.d*(a.n - 1) )* n / 2;
            return s;
        }
        public double GetElement(int k)
        {
            double a = this.a0 + (k - 1) * this.d;
            return a;
        }
    }
}
