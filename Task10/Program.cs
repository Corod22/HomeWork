// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
int amount = threeDigitNumber.ToString().Length;
// int result = (threeDigitNumber / 10) % 10;
if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine($"Вторая цифра числа {threeDigitNumber} -> {InCenter(threeDigitNumber)}");
}
Console.Read();

int InCenter (int a)
{
    int result = (threeDigitNumber / 10) % 10;
    return result;
}

