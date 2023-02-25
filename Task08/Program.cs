// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число n");
int n=Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n+1; i=i+2)
{
    if (i>0)
    {
    Console.Write(i+" ");
    }
}
Console.Read();

// Console.WriteLine("Введите число n");
// int n=Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < n+1; i++)
// {
//     if (i>0)
//     {
//         if (i%2==0)
//         {
//     Console.Write(i+" ");
//         }
//     }
// }
// Console.Read();