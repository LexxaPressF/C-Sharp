using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    abstract class Item : IComparable
    {
        //Свойства
        protected long invNumber; // инвентарный номер — целое число
        protected bool taken; // хранит состояние объекта - взят ли на руки
        //Конструкторы
        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }
        public Item()
        {
            this.taken = true;
        }
        //Методы
        //Новый метода сравнения
        int IComparable.CompareTo(object obj)
        {
            Item it = (Item)obj;
            if (this.invNumber == it.invNumber) return 0;
            else if (this.invNumber > it.invNumber) return 1;
            else return -1;
        }
        public bool IsAvailable()
        { // истина, если этот предмет имеется в библиотеке
            if (taken == true)
                return true;
            else
                return false;
        }
        public long GetInvNumber()
        {// инвентарный номер
            return invNumber;
        }
        public void Take()
        {// операция "взять"
            taken = false;
        }
        public abstract void Return();//Теперь он абстрактный
        public virtual void Print()
        {// Вывод
            Console.WriteLine("Состояние единицы хранения:\n Инвентарный " +
                "номер: {0}\n Наличие: {1} ", invNumber, taken);
        }

    }
}
