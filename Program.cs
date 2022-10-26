Console.Clear();

Console.WriteLine("Задача 47; Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.");
Console.WriteLine("Задача 50; Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine("Задача 52; Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine("Задача 60; Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
Console.WriteLine("Задача 62; Напишите программу, которая заполнит спирально массив 4 на 4.");
Console.WriteLine("Введите номер задачи от 1 до 5;");
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
        int rows1 = 5;
        int columns1 = 5;
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
        int rows2 = 5;
        int columns2 = 5;
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





    case 4:
        int[,,] array4 = new int[2, 2, 5];
        int[] nums = new int[90];
        FillArray1(nums);
        FullArray2(array4, nums);
        PrintArray2(array4);
        

        void FillArray1(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = 10 + i;
            }
        }

        void FullArray2(int[,,] Array, int[] element)
        {
            int count = 0; int number;
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    for (int k = 0; k < Array.GetLength(2); k++)
                    {
                        number = new Random().Next(90);
                        while (element[number] == 0)
                        {
                            number = count;
                            count++;
                        }
                        Array[i, j, k] = element[number];
                        element[number] = 0;
                        count = 0;
                    }
                }
            }
        }

        void PrintArray2(int[,,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {

                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    for (int k = 0; k < Array.GetLength(2); k++)
                    {
                        Console.Write($"{Array[i, j, k]}({i},{j},{k}) ");
                    }
                    Console.WriteLine();
                }
            }


        }
        break;




    case 5:
        int n = 4;
        int number = 1;

        Print2(SpiralArray(n, number));

        int[,] SpiralArray(int n, int number)
        {
            int[,] array = new int[n, n];
            int count = 0;
            int row; int column;
            while (number < n * n + 1)
            {
                for (column = count; column < n - count; column++) array[count, column] = number++;
                for (row = count + 1; row < n - count; row++) array[row, n - count - 1] = number++;
                for (column = n - count - 2; column > count; column--) array[n - count - 1, column] = number++;
                for (row = n - count - 1; row > count; row--) array[row, count] = number++;
                count++;
            }
            return array;
        }

        void Print2(int[,] array)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write("{0,6:d2}", array[row, column]);
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



