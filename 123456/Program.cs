﻿// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

double[] AverageMeaning(int[,] matrix)
{   
    double avrg = 0;
    double[] array = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double averageMeaning = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            averageMeaning = averageMeaning + matrix[i, j];
        }
        //avrg =  averageMeaning;
        avrg = Math.Round(averageMeaning / matrix.GetLength(0), 2);
        //Console.Write($"{avrg}   ");
        array[j] =avrg;
    }
    return array;
}
void PrintArray(double[] arr)
{
    int count = arr.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < count - 1) Console.Write("; ");
    }
    Console.Write("]");
}
int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
// AverageMeaning(array2d);
double[] array = AverageMeaning(array2d);
PrintArray(array);