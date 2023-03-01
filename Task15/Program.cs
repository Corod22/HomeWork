// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру, обозначающую день недели");
int dayWeek = Convert.ToInt32(Console.ReadLine());
if (dayWeek > 0 && dayWeek < 8)
{
    WeekDay(dayWeek);
}
else
{
    Console.WriteLine("Ввели некорректную цифру");
}


int WeekDay(int day)
{
if (day > 5)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
    return day;
}