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

int dig2 = Counter(number);

PalinDrome(dig2);

Console.WriteLine(Сonclusion(number, result) ? "Да": "Нет");

Console.Read();



int Counter(int numm)
{
    int digits = 0;
    int number2 = numm;
    while (number2 > 0)
    {
        number2 = number2 / 10;
        digits++;
    }
    int dig = ((int)Math.Pow(10, digits)) / 10;
    return dig;
}


int PalinDrome(int dig3)
{
    while (dig3 > 0)
    {
        a = num % 10;
        num = num / 10;
        result = result + a * dig3;
        dig3 = dig3 / 10;
    }
    return result;
}

bool Сonclusion(int number4, int result4)
{
  return number4==result4;
}

// if (number == result)
// {
//     Console.WriteLine($"Число {number} является палиндромом?-> да ");
// }
// else
// {
//     Console.WriteLine($"Число {number} является палиндромом?-> нет");
// }


// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int num = number;
// int result = 0;
// int a = 0;

// int digits = 0; 
// int number2=number;
// while (number2 > 0)
// {
//   number2 = number2/10;
//   digits++;
// }
// int dig = ((int)Math.Pow(10, digits))/10;

//     while (dig>0)
//     {
//     a = num % 10;
//     num = num / 10;
//     result = result + a * dig;
//     dig=dig/10;
//     }
//     if (number==result)
//     {
//         Console.WriteLine($"Число {number}-> да, палидром ");
//     }
//     else 
//     {
//         Console.WriteLine($"Число {number} -> нет, не палидром");
//     }


// Console.Read();