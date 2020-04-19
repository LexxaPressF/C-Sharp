using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        //Свойства
        public double a; //1 сторона
        public double b; //2 сторона
        public double c; //3 сторона
        //Конструкторы
        public Triangle(double a, double b, double c) //Полный конструктор
        {
            bool ok = Proverka(a, b, c); //Метод проверки треугольника на существование
            if (ok == false)
            {
                Console.WriteLine("Треугольника не существует");
                this.a = 0; this.b = 0; this.c = 0;
            }
            else
            {
                this.a = a; this.b = b; this.c = c;
            }
        }
        public Triangle(double a)//Конструктор для равностороннего треугольника
        {
            this.a = a;this.b = a;this.c = a;
        }
        public Triangle() //Пустой конструктор
        {
            Console.WriteLine("Введите все три стороны через enter:");
            double a, b, c;//Стороны
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            bool ok = Proverka(a, b, c);
            if (ok == false)
            {
                Console.WriteLine("Треугольника не существует");
                this.a = 0;this.b = 0; this.c = 0;
            }
            else
            {
                this.a = a; this.b = b;this.c = c;
            }
        }
        //Методы
        private bool Proverka(double a, double b, double c) 
        { //Проверка на существование треугольника
            bool ok;
            if (a <= b + c | b <= a + c | c <= a + b) ok = true;
            else ok = false;
            return ok;
        }
        static public double Ploshad(Triangle a)
        { //Вычисления площади
            double p = Perimetr(a) / 2;
            double s = Math.Sqrt(p * (p - a.a) * (p - a.b) * (p - a.c));
            return s;
        }
        static public double Perimetr(Triangle a)
        { //Вычисление периметра
            double p = a.a + a.b + a.c;return p;
        }
        static public void Print(ref Triangle a)
        { //Вывод всех данных
            double p = Triangle.Perimetr(a); double s = Triangle.Ploshad(a);
            Console.WriteLine("------Данные по трeугольнику------");
            Console.WriteLine("1-я сторона: {0}\n2-я сторона {1}\n" +
                "3-я сторона {2}\nПериметр: {3}\nПлощадь: {4}", a.a, a.b, a.c,
               p, s);
        }
    }
}
