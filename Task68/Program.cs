// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
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
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}
int numberM = NumberM();
int numberN = NumberN();
if (numberM <= 0 | numberN <= 0)
{
    Console.WriteLine("Введи целое натуральное число");
}
else
{
    Console.WriteLine($"A({numberM}, {numberN}) = {Akkerman(numberM, numberN)}");
}
Console.ReadKey();

