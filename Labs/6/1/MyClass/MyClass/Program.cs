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
            Book b1 = new Book();
            b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123,
                    2018);
            Book.SetPrice(12);
            b1.Print();
            Console.WriteLine("\n Итоговая стоимость аренды: {0} p.",
            b1.PriceBook(3));
            //Упражнение 2
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь",
            1234, 2013); //Передача в конструктор произвольных параметров
            b2.Print(); //Вывод информации
            Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");
            b3.Print();
        }
    }
}
