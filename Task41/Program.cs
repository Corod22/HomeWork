// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите количество чисел M");
int numberM = Convert.ToInt32(Console.ReadLine());

int[] array = new int[numberM];
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
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
int PositiveNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count = count + 1;
    }
    return count;
}
FillArray(array);
PrintArray(array);
int count = PositiveNumber(array);
Console.WriteLine($"Пользователь ввел {count} числа(чисел) больше ноля");
Console.ReadKey();