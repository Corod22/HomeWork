// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 999)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{

    Console.WriteLine(ThirdDigit(number));
}
Console.Read();

int ThirdDigit(int thir)
{
    while (thir > 999)
    {
        thir = thir / 10;
    }
    int result = thir % 10;
    return result;
}