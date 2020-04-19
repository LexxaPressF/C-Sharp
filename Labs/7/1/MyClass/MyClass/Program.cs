using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Program
    {
        static void Main()
        {
            Publisher publ = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234,
            new DateTime(2014, 12, 14));
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", publ, 1234, 2013,
            101, true);
            b2.Print();
        }
    }
}
