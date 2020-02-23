using System;

namespace Summa
{
    class Program
    {
        static void Main()
        {
            int i, k, m, s; //Объявление аргументов
            ReTry1:
            Console.Write("Введите k: ");
            k = int.Parse(Console.ReadLine());
            ReTry:
            Console.Write("Введите m (меньше 100): ");
            m = int.Parse(Console.ReadLine());          //Получение переменных от пользователя
            if (m > 100)  //В случае нарушения условия пользователя вернет обратно
            {
                Console.WriteLine("ЗАНОВО");
                goto ReTry;
            }
            else if (k > m)
            {
                Console.WriteLine("ЗАНОВО");
                goto ReTry1;
            }
            s = 0;
            for (i = 1; i <= 100; i++)      //Итерация по i от 1 до 100
            {
                if (i > k && i < m) 
                    continue;//Прерывание действия в случае выполнения условия и переход к следующему этапу итерации
                s += i; //Формирование суммы
            }
            Console.Write("Сумма чисел от 0 до {0} и от {1} до 100: {2}", k, m, s); //Вывод суммы в консоль
        }
    }
}
