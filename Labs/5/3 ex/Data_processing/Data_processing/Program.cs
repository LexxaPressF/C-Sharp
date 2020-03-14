using System;

namespace Data_processing
{
    class Program
    {
        static void Vvod(ref double[] mas) //Функция для ввода массива
        {
            Console.WriteLine("Введите массив:");
            int i; //Для итерации
            for (i = 0; i < mas.Length; i++)//По столбикам
            {
                Console.Write("{0} = ", i);
                mas[i] = double.Parse(Console.ReadLine());
            }
        }
        static void Vyvod(ref double[] mas) //Функция для вывода массива
        {
            Console.WriteLine("------Значения массива------");
            int i; //Для итерации
            for (i=0; i < mas.Length; i++)
            {
            Console.WriteLine(i + "-й элемент = " + mas[i]);
            }
        }
        static double[] Processing(ref double[] mas) //Обработка массива
        {                                  //Он возвращает массив найденных значений
            
            double s = 0, av = 0, neg = 0, odd=0, max= mas[0], min= mas[0], sm = 1; //Искомые значения
            double temp1 = 0, temp2 = 0;
            int i; //Для итерации
            for (i=0; i<mas.Length; i++)//Цикл для нахождения суммы, кол-ва отрицю и нечетных
            {
                s += mas[i];
                if (mas[i] < 0) neg += mas[i];
                if ((mas[i] % 2) == 1) odd += mas[i];
            }
            for (i = 1; i < mas.Length; i++)
            {
                if (mas[i] < min) { min = mas[i]; temp1 = i; }
                if (mas[i] > max) { max = mas[i]; temp2 = i; }
            }
            min = temp1;
            max = temp2;
            if (max > min) for (i = (int)min + 1; i < (int)max; i++) sm *= mas[i];
            else for (i = (int)max + 1; i < (int)min; i++) sm *= mas[i];
            av = s / mas.Length;
            double[] pr = new[] { s, av, neg, odd, max, sm}; // Массив для результатов
            Console.WriteLine("Сумма всех элементов: {0}\nСреднее значение массива: {1}" +
                "\nСумма отрицательных элементов: {2}\nСумма нечетных элементов: {3}" +
                "\nНомер максимального элемента: {4}\nПроизведение между максимумом и минимумом: {5}",
                pr[0], pr[1], pr[2], pr[3], pr[4], pr[5]);
            return pr;
        }
        static void Main()
        {
            Console.Write("Введите кол-во элементов в массиве: ");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            Vvod(ref a);
            Vyvod(ref a);
            Processing(ref a);
        }
    }
}
