using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    class Program
    {
        static void Main()
        {
            ArithmeticProgression a = new ArithmeticProgression(1, 4, 2);
            ArithmeticProgression a1 = new ArithmeticProgression();
            GeometricProgression b = new GeometricProgression(1, 4, 2);
            GeometricProgression b1 = new GeometricProgression();
            a.Print();
            a1.Print();
            b.Print();
            b1.Print();
            Console.WriteLine(a1.GetElement(3));
            Console.WriteLine(b1.GetElement(3));
        }
    }
}




