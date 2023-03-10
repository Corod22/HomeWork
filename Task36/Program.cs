// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 100);
    }
}
void SumOddNumders(int[] arr)
{
    int sumOddNumders = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumOddNumders=sumOddNumders+arr[i];
        }
    }
    Console.Write($" Сумма элементов, стоящие на нечётных позициях->{sumOddNumders}");
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
FillArray(array);
PrintArray(array);
SumOddNumders(array);
Console.Read();