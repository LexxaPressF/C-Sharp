using MyClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassTest
{
    class Program
    {
        static void Main()
        {
            Publisher publ = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234,
            new DateTime(2014, 12, 14));
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", publ, 1234, 2013, 101, true);
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014,
            1235, true);
            mag1.Take();
            mag1.Print();
            Audit.RunAudit();
            mag1.Subs();
            mag1.Print();
            List<Item> itlist = new List<Item>();
            itlist.AddRange(new Item[] { b2, mag1 });
            itlist.Sort();
            Console.WriteLine("\nСортировка по инвентарному номеру");
            foreach(Item x in itlist)
            {
                x.Print();
            }
        }
    }
}
