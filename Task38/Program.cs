// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());

double[] array = new double[n];
void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(new Random().Next(0, 10) + new Random().NextDouble(), 2);
    }
}
double MaxElementArray(double[] arr)
{
    double maxElementArray = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (maxElementArray < arr[i])
        {
            maxElementArray = arr[i];
        }
    }
    return maxElementArray;
}
double MinElementArray(double[] arr)
{
    double minElementArray = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (minElementArray > arr[i])
        {
            minElementArray = arr[i];
        }
    }
    return minElementArray;
}
void PrintArray(double[] arr)
{
    int count = arr.Length;
    Console.Write("Массив вещественных чисел [");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < count - 1) Console.Write("; ");
    }
    Console.WriteLine("]");
}
FillArray(array);
PrintArray(array);
MaxElementArray(array);
MinElementArray(array);
double maxElement = MaxElementArray(array);
double minElement = MinElementArray(array);
Console.WriteLine($"Максимальный элемент -> {maxElement}");
Console.WriteLine($"Минимальный элемент -> {minElement}");
Console.WriteLine($"Разница между максимальным и маинимальным элементом - > {Math.Round(maxElement - minElement, 2)}");
Console.Read();