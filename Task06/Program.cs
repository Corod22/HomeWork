// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите число");
int Ch = Convert.ToInt32(Console.ReadLine());
if (Ch % 2 == 0)
{
    Console.WriteLine("Число " + Ch + " чётное");
}
else
{
    Console.WriteLine("Число " + Ch + " нечётное");
}
Console.Read();