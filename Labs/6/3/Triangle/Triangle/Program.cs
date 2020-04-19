using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main()
        {
            Triangle a = new Triangle(4, 5, 3),
                b = new Triangle(1),
                c = new Triangle();
            Triangle.Print(ref a);
            Triangle.Print(ref b);
            Triangle.Print(ref c);
        }
    }
}
