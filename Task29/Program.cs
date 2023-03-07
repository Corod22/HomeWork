// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
int[] array = new int[8];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i}");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
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