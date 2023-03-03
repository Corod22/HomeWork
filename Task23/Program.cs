// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число N");
int number= Convert.ToInt32(Console.ReadLine());

Cubed(number);

void Cubed(int num)
{
    int index=1;
    while(index<=num)
    {
    Console.WriteLine($"{index,5} {Math.Pow(index, 3),5}");
    index++;
    }
}
Console.Read();

