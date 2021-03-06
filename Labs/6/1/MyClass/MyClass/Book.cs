﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Book
    {
        //Свойства
        public string Author { get; set; } // автор
        public string Title { get; set; } // название
        public string Publisher { get; set; } // издательство
        public int Pages { get; set; } // кол-во страниц
        public int Year { get; set; } // год издания
        //Методы
        public static double Price //Доступ к закрытому price
        {
            get { return price; } //Метод получения
            set { if (value > 9) price = value; } //Метод задания
        }
        public void SetBook(string author, string title, string publisher,
int pages, int year) //Произвольный конструктор
        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.Pages = pages;
            this.Year = year;
        }
        public static void SetPrice(double price) //Установление price
        {
            Book.Price = price;
        }
        public override string ToString() //Переопределения метода
        {                                 //Специально для класса
            string bs = String.Format("\nКнига:\n Автор: {0}\n Название: {1}" +
                "\nГод издания: {2}\n {3}стр.\n Стоимость аренды: " +
                "{4} ", Author, Title, Year, Pages, Book.price);
            return bs;
        }
        public void Print() //Вывод 
        {
            Console.WriteLine(this);
        }
        public double PriceBook(int s) //Стоимость за s книг
        {
            double cost = s * price;
            return cost;
        }
        //Упражнение 2
        public Book(string author, string title, string publisher, int
        pages, int year) //Конструктор
        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
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
