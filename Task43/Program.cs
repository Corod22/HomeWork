// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите коэффициент k1");
double сoeffK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1");
double сoeffB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2");
double сoeffK2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2");
double сoeffB2 = Convert.ToInt32(Console.ReadLine());
if (сoeffK1 != сoeffK2)
{
    double x = FindX(сoeffK1, сoeffB1, сoeffK2, сoeffB2);
    double y = FindY(x, сoeffK1, сoeffB1);
    Console.WriteLine($"Точки пересечения ({x},{y})");
}
else
{
    Console.WriteLine("Прямые параллельны. Точки пересечения нет");
}

double FindX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    Console.WriteLine(x);
    return x;
}
double FindY(double x, double k1, double b1)
{
    double y = k1 * x + b1;
    return y;
}