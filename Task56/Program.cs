// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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
int[] SummString(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ = summ + matrix[i, j];
        }
        array[i] = summ;
    }
    return array;
}
void PrintArray(int[] arr)
{
    int count = arr.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < count - 1) Console.Write(", ");
    }
    Console.Write("]");
}
int MinSummElement(int[] arr)
{
    int a = arr[0];
    for ( int i = 1; i < arr.Length; i++)
    {
        if (a > arr[i])
        {
            a=arr[i];
        }
    } 
    return a; 
}
int[] MinString(int[]arr, int minSum)
{
    int[] array = new int[arr.Length];
    //int count=0;
    for (int i = 0; i <arr.Length ; i++)
    {
        if (minSum==arr[i])
        {
          Console.WriteLine($"Строка с наименьшей суммой элементов {i+1}");       
        }
    }
}
// void MinString(int[]arr, int minSum)
// {
//     //int count=0;
//     for (int i = 0; i <arr.Length ; i++)
//     {
//         if (minSum==arr[i])
//         {
//           Console.WriteLine($"Строка с наименьшей суммой элементов {i+1}");       
//         }
//     }
// }

int[,] array2d = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2d);
int[] summString = SummString(array2d);
PrintArray(summString);
int a=MinSummElement(summString);
//Console.WriteLine($"Строка с наименьшец суммой {a}");
//MinSummElement(summString);
Console.WriteLine();
MinString(summString,a);


