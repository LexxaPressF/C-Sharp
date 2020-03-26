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
        public double d; //Разность между элементами
        public double s; //Сумма прогрессии
        //Конструкторы
        public ArithmeticProgression(double a, double b, 
            double d): base(a,b)
        {
            this.d = d;
            this.s = Summa(this);
        }
        public ArithmeticProgression() : base()
        {
            Console.Write("Введите разность между элементами: ");
            double d = double.Parse(Console.ReadLine());
            this.d = d;
            this.s = Summa(this);
        }
        //Методы
        new public void Print()
        {
            base.Print();
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
        override public double GetElement(int k)
        {
            double a = this.a0 + (k - 1) * this.d;
            return a;
        }
    }
}
