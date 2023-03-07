// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{  
    int resultR=SumDigits(number);
        Console.WriteLine($"Cумма цфр в числе {number}->{resultR}");
}
else Console.WriteLine("Введите натуральное число");
    
int SumDigits(int numR)
{
  int result = 0;
    numR=number;
    while (numR > 0)
    {
        int RemainderNumber = numR % 10;
        result = result + RemainderNumber;
        numR = numR / 10;
    }
    return result;
}

Console.Read();