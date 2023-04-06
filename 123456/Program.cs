// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int NumberM()
{
    Console.WriteLine("Введите натуральное число M");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int NumberN()
{
    Console.WriteLine("Введите натуральное число N");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[] ArraySum(int s1, int s2)
{
    int n = 0;
    if (s1 > s2)
    {
        n = s1 - s2 + 1;
    }
    else
    {
        n = s2 - s1 + 1;
    }
    int[] array = new int[n];
    array[0] = s1;
    int count = s2 - s1;
    for (int i = 1; i <= count; i++)
    {
        array[i] = array[i - 1] + 1;
    }
    return array;
}
int NumberSum(int[] arr)
{
    int sum = 0;
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        sum = sum + arr[i];
    }
    return sum;

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
int numberM = NumberM();
int numberN = NumberN();
if (numberN > numberM)
{
    int[] arraySum = ArraySum(numberM, numberN);
    PrintArray(arraySum);
    int sum = NumberSum(arraySum);
    Console.WriteLine();
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} ->{sum}");
}
else
{
    int[] arraySum = ArraySum(numberN, numberM);
    PrintArray(arraySum);
    int sum = NumberSum(arraySum);
    Console.WriteLine();
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberN} до {numberM} ->{sum}");
}    