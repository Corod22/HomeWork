﻿// Задача 64: Задайте значение N. Напишите программу, 
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



