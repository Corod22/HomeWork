// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int Number()
{
    Console.WriteLine("Введите натуральное число N");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void NaturalNumber(int num)
{
    if (num==0) return;
    Console.Write($"{num} ");
    NaturalNumber(num-1);
}
int number = Number();
if (number>0)
{
NaturalNumber(number);
}
else
{
    Console.WriteLine("Ввели ненатуральное число");
}
Console.ReadKey();

// int[] NumberNatural(int num)
// {
//     int[] array = new int[num];
//     array[0] = num;
//     int count=num;
//     for (int i = 1; i <count; i++)
//     {
//         array[i] = array[i-1]-1;
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     int count = arr.Length;
//     Console.Write("[");
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{arr[i]}");
//         if (i < count - 1) Console.Write(", ");
//     }
//     Console.Write("]");
// }
// int number = Number();
// if (number >0)
// {
// int[] numberNatural = NumberNatural(number);
// PrintArray(numberNatural);
// }
// else 
// {
//     Console.WriteLine("Ввели не натуральное число");
// }

