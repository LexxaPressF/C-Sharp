using System;

namespace Area_of_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, p, s; //Объявление переменных для стороны периметра и площади 
            Console.Write("Введите значение периметра треугольника: ");
            try //Ловим ошибки в коде
            {
            Point:
                p = double.Parse(Console.ReadLine()); //Считываем введеную строку и сразу преобразуем ее в double 
                if (p<=0){
                Console.Write("Введите значение периметра треугольника больше нуля: "); 
                goto Point; //Возвращаемся если значение неверное
                }
                a = p / 3; //Находим сторону
                p = p / 2; //Получаем полупериметр
                s = Math.Sqrt(p * Math.Pow((p - a), 3)); //Вычисляем площадь 
                Console.WriteLine("Сторона Площадь"); //Выводим значения в таблице 
                Console.WriteLine("{0:0.00} \t{l:0.00}", a, s); //Выводим 2 знака после запятой
            }
            catch (Exception е)
            {
                Console.WriteLine("HanfleHa ошибка: {0}", е); //Универсальная обработка ошибок

            }
        }
}
