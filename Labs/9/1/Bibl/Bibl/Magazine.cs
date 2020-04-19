﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    public delegate void ProcessMagazineDelegate(Magazine mag,
                    DateTime dt);
    public class Magazine : Item, IPubs
    {
        //8 лаба
        public static event ProcessMagazineDelegate Subscribe = null;
        // Свойства
        public bool IfSubs { get; set; } //Подписка
        public string Volume { get; set; } // том
        public int Number { get; set; } // номер
        public string Title { get; set; } // название
        public int Year { get; set; } // год выпуска 
        // Конструкторы
        public Magazine(string volume, int number, string title, int year,
        long invNumber, bool taken) : base(invNumber, taken)
        {
            this.Volume = volume;
            this.Number = number;
            this.Title = title;
            this.Year = year;
        }
        public Magazine() //Пустой конструктор???
        {
        }
        //Методы
        public void Subs()
        {
            IfSubs = true;
            if (Subscribe != null)
                Subscribe(this, DateTime.Now);
        }
        public override void Return() // операция "вернуть"
        {
            taken = true;
        }
        public override string ToString()
        {
            string bs = String.Format("\nЖурнал:\n Том: {0}\n Номер: " +
                "{1}\n Название: {2} \n Год выпуска: {3} \n Статус подписки: {4}",
                Volume, Number, Title, Year, IfSubs);
            return bs;
        }
        public override void Print()
        {
            Console.WriteLine(this);
            base.Print();
        }
        
    }
}