using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    public struct Distance
    {
        public int feet;
        public int inch;
        public void Display()
        {
            while (this.inch >= 12.0)
            {
                this.inch = this.inch - 12;
                this.feet++;
            }
            Console.WriteLine("{0} '- {1}\"", this.feet, this.inch);
        }
        public static Distance AddDist(Distance i, Distance j)
        {
            Distance d; 
            d.feet = i.feet + j.feet;
            d.inch = i.inch + j.inch; 
            while (d.inch >= 12.0) 
            { 
                d.inch = d.inch-12; 
                d.feet++; 
            }
            return d;
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Distance first;
            Distance second;
            Console.WriteLine("--------Первая переменная--------");
            Console.Write("Введите значение футов: ");
            first.inch = int.Parse(Console.ReadLine());
            Console.Write("Введите значение дюймов: ");
            first.feet = int.Parse(Console.ReadLine());
            Console.WriteLine("--------Вторая переменная--------");
            Console.Write("Введите значение футов: ");
            second.inch = int.Parse(Console.ReadLine());
            Console.Write("Введите значение дюймов: ");
            second.feet = int.Parse(Console.ReadLine());
            Distance third = Distance.AddDist(first, second);
            Console.WriteLine("--------Первая переменная--------");
            first.Display();
            Console.WriteLine("--------Вторая переменная--------");
            second.Display();
            Console.WriteLine("--------Третья переменная--------");
            third.Display();
        }
    }
}
