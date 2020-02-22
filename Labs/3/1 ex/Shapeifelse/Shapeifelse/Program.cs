using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapeifelse
{
    class Program
    {
        static void Main()
        {
            Console.Write("x=");                        
            float x = float.Parse(Console.ReadLine());  //Получаем первую точку
            Console.Write("y=");
            float y = float.Parse(Console.ReadLine());  //Получаем вторую точку
            if (x * x + y * y < 9 && y > 0)             //Первое условие
                Console.WriteLine("внутри");            //Действия при нем
            else if (x * x + y * y > 9 || y < 0)        //Второе условие
                Console.WriteLine("вне");               //Действия
            else Console.WriteLine("на границе");       //Если ни одно из условий не выполнено

        }
    }
}


