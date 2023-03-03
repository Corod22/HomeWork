// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212->нет
// 12821->да
// 23432->да
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int num = number;
int result = 0;
int a = 0;

int digits = 0; 
int number2=number;
while (number2 > 0)
{
  number2 = number2/10;
  digits++;
}
int dig = ((int)Math.Pow(10, digits))/10;

    while (dig>0)
    {
    a = num % 10;
    num = num / 10;
    result = result + a * dig;
    dig=dig/10;
    }
    if (number==result)
    {
        Console.WriteLine($"Число {number}-> да, палидром ");
    }
    else 
    {
        Console.WriteLine($"Число {number} -> нет, не палидром");
    }


Console.Read();
// Console.WriteLine("Введите пятизначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// int num = number;
// int result = 0;
// int a = 0;
// if (num < 100000)
// {
//     a = num % 10;
//     num = num / 10;
//     result = result + a * 10000;


//     a = num % 10;
//     num = num / 10;
//     result = result + a * 1000;

//     a = num % 10;
//     num = num / 10;
//     result = result + a * 100;

//     a = num % 10;
//     num = num / 10;
//     result = result + a*10;

//     a = num % 10;
//     num = num / 10;
//     result = result + a;

//     Console.WriteLine($"Палидром числа {number} - > {result}");

// }
// else
// {
//     Console.WriteLine("Введите пятизначное число");
// }


// Console.Read();



