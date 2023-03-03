// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212->нет
// 12821->да
// 23432->да
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int num = number;
int result = 0;
int a = 0;
int tK = 10000;
if (num < 100000)
{
    while (tK>0)
    {
    a = num % 10;
    num = num / 10;
    result = result + a * tK;
    tK=tK/10;
    }
    if (number==result)
    {
        Console.WriteLine($"Число {number}-> да, палидром ");
    }
    else 
    {
        Console.WriteLine($"Число {number} -> нет, не палидром");
    }
    // Console.WriteLine($"Палидром числа {number} - > {result}");

}
else
{
    Console.WriteLine("Введите пятизначное число");
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



