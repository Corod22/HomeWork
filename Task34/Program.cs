// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размерность массива");
int n=Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        //Console.WriteLine($"Введите {i}");
        arr[i] = new Random().Next(0, 1000);
    }
}
void PositiveNumber(int[] arr)
{
    int quantityPositiveNumber=0;
    for (int i = 0; i < arr.Length ; i++)
    {
       if (arr[i]%2==0)
       {
          quantityPositiveNumber++;
       } 
    }
    Console.Write($" Чётных чисел в массиве->{quantityPositiveNumber}");
}
void PrintArray(int[] arr)
{
    int count = arr.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i] }");
        if (i<count-1) Console.Write(", "); 
    }
    Console.Write("]");
}

FillArray(array);
PrintArray(array);
PositiveNumber(array);
//Console.Write($"Чётных чисел в массиве->{quantityPositiveNumber}");
Console.Read();