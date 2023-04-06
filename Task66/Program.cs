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

int SumNumber(int firstNum, int secondNum)
{

    if (firstNum == secondNum)
        return secondNum;
    else return firstNum + SumNumber(firstNum + 1, secondNum);

}
int numberM = NumberM();
int numberN = NumberN();
int a = 0;
if (numberM <= 0 | numberN <= 0)
{
    Console.WriteLine("Введи целое натуральное число");
}
else
{
    if (numberM > numberN)
    {
        a = numberN;
        numberN = numberM;
        numberM = a;
    }
    SumNumber(numberM, numberN);
    if (numberM < numberN)
    {
        Console.Write($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} равно {SumNumber(numberM, numberN)}");
    }
    else
        Console.Write($"Сумма натуральных элементов в промежутке от {numberN} до {numberM} равно {SumNumber(numberM, numberN)}");
}
Console.ReadKey();

