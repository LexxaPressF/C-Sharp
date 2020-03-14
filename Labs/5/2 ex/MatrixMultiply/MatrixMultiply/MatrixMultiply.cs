using System;

namespace MatrixMultiply
{
    class MatrixMultiply
    {
        static void Vvod(ref double[,] mas) //Функция для ввода массива
        {
            int i,j; //Для итерации
            for(j=0; j<2; j++)//По столбикам
            {
                for (i = 0; i < 2; i++)//По рядам
                {
                    switch (j)
                    {
                        case 0: Console.Write((i + 1) + "-я переменная: "); break;
                        case 1: Console.Write((i + 3) + "-я переменная: "); break;
                    }
                    mas[j,i] = double.Parse(Console.ReadLine());
                }        
            }
        }
        static void Vyvod(ref double[,] mas) //Функция для вывода массива
        {
            int i, j; //Для итерации
            Console.WriteLine("---Значение массива---");
            Console.WriteLine("| {0}  {1} |\n| {2}  {3} |", mas[0, 0],
               mas[0, 1], mas[1, 0], mas[1, 1]);
        }
        static void Main()
        {
            double[,] firstArray = new double[2, 2], secondArray = new double[2, 2];//Объявление массивов
            Console.WriteLine("Введите значения 1-го массива:");
            Vvod(ref firstArray);
            Console.WriteLine("Введите значения 2-го массива:");
            Vvod(ref secondArray);
            Vyvod(ref firstArray);
            Vyvod(ref secondArray);
            double[,] result = Multiply(firstArray, secondArray);
            //Vyvod(ref result);
            Output(result);

        }

        private static double[,] Multiply(double[,] firstArray, double[,] secondArray)
        {
            double[,] result = new double[2, 2];
            for (int r = 0; r < result.GetLength(0); r++)
            {
                for (int c = 0; c < result.GetLength(1); c++)
                {
                    result[r, c] += firstArray[r, 0] * secondArray[0, c] + firstArray[r, 1] * secondArray[1, c];
                }
            }
            return result;
        }

        private static void Output(double[,] result)
        {
            Console.WriteLine(result[0, 0]);
            Console.WriteLine(result[0, 1]);
            Console.WriteLine(result[1, 0]);
            Console.WriteLine(result[1, 1]);
        }
    }
}
