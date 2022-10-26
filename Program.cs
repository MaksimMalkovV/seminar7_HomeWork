Console.WriteLine("Задача 1; Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
Console.WriteLine("Задача 2; апишите программу, которая на вход принимает позиции элемента в двумерном массиве, \n        и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine("Задача 3; Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine("Введите номер задачи от 1 до 3;");
int name = Convert.ToInt32(Console.ReadLine()!);

switch (name)
{

    case 1:
        int rows = ReadLine("Введите значение строк: ");
        int columns = ReadLine("введите значение столбцов; ");
        double[,] array = new double[rows, columns];
        FullArray1(array);
        PrintArray1(array);
        void FullArray1(double[,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
                }
            }
        }
        void PrintArray1(double[,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write("{0,6:f1}", Array[i, j]);
                }
                Console.WriteLine();
            }
        }
        break;

    case 3:
        int rows1 = ReadLine("Введите значение строк: ");
        int columns1 = ReadLine("введите значение столбцов; ");
        double[,] array1 = new double[rows1, columns1];
        FullArray(array1);



        void FullArray(double[,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Array[i, j] = new Random().Next(0, 10);
                }
            }
        }
        void Srednnearifm(double[,] array)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                double avarage = 0;
                for (int i = 0; i < array.GetLength(0); i++) avarage = (avarage + array[i, j]);
                avarage = avarage / rows1;
                Console.Write("{0,6:f2}", avarage);
            }

        }

        Console.WriteLine();
        PrintArray(array1);
        Console.WriteLine("Среднее арифметическое каждого столбца.");
        Srednnearifm(array1);
        break;

    case 2:
        int rows2 = ReadLine("Введите значение строк: ");
        int columns2 = ReadLine("введите значение столбцов; ");
        double[,] array2 = new double[rows2, columns2];

        FullArray(array2);
        PrintArray(array2);
        ValuePoisk(array2);
        void ValuePoisk(double[,] Array)
        {
            int i = ReadLine("Введите значение i ;  ");
            int j = ReadLine("введите значение j ;  ");
            if (i > Array.GetLength(0) || j > Array.GetLength(1)) Console.Write("Такого элемента нет.");
            else Console.WriteLine($"Значение элемента равно {Array[i - 1, j - 1]}");
        }

        void PrintArray(double[,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write("{0,6}", Array[i, j]);
                }
                Console.WriteLine();
            }
        }
        break;


        int ReadLine(string massage)
        {
            Console.WriteLine(massage);
            var Value = int.Parse(Console.ReadLine()!);
            return Value;
        }
}


