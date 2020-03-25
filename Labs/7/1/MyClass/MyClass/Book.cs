using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Book : Item
    {
        // Метод скрывающий родительский
        override public void Print() //Вывод 
        {
            Console.WriteLine(this);
            base.Print(); //Вызов базового метода
        }
        //Новый метод 2
        public void ReturnSrok()
        {
            returnSrok = true;
        }
        //Новый метод
        public void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }

        //Свойства
        public string Author { get; set; } // автор
        public string Title { get; set; } // название
        // public string Publisher { get; set; } // издательство
        public Publisher Publ { get; set; }
        public int Pages { get; set; } // кол-во страниц
        public int Year { get; set; } // год издания
        public bool returnSrok { get; private set; } //Возврат книги в срок
        //Методыp
        //Измененый
        public override string ToString() //Переопределения метода
        {                                 //Специально для класса
            string bs = String.Format("\nКнига:\n Автор: {0}\n Название: {1}" +
                "\nГод издания: {2}\n {3}стр.\n Стоимость аренды: " +
                "{4} \nИздательство{5}", Author, Title, Year, Pages, Book.price,
                Publ.ToString());
            return bs;
        }
        //Новый 
        public override void Return() // операция "вернуть"
        {
            if (returnSrok == true)
                taken = true;
            else
                taken = false;
        }
        public static double Price //Доступ к закрытому price
        {
            get { return price; } //Метод получения
            set { if (value > 9) price = value; } //Метод задания
        }
        public void SetBook(string author, string title, Publisher
        publisher, int pages, int year) //Произвольный конструктор
        {
            this.Author = author;
            this.Title = title;
            this.Publ = publisher;
            this.Pages = pages;
            this.Year = year;
        }
        public static void SetPrice(double price) //Установление price
        {
            Book.Price = price;
        }
        
        public double PriceBook(int s) //Стоимость за s книг
        {
            double cost = s * price;
            return cost;
        }
        //Упражнение 2
        public Book(string author, string title, Publisher
        publisher, int pages, int year, long invNumber, bool taken) : base(invNumber, taken)
        //Конструктор + ссылка на базовый
        {
            this.Author = author;
            this.Title = title;
            this.Publ = publisher;
            this.Pages = pages;
            this.Year = year;
        }
        public Book() //Пустой конструктор
        { }
        static Book()
        {
            Price = 9;
        }
        private static double price; //Минимальная стоимость
        public Book(string author, string title) //Конструктор с 2-мя входными параметрами
        {
            this.Author = author;
            this.Title = title;
        }
    }
}
