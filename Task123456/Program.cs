Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число M:");
int numberN = int.Parse(Console.ReadLine());

///Метод нахождения суммы натуральных элементов в промежутке от M до N
void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

GapNumberSum(numberM, numberN, 0);

// int[] ArraySum(int s1, int s2)
// {
//     int n = 0;
//     if (s1 > s2)
//     {
//         n = s1 - s2 + 1;
//     }
//     else
//     {
//         n = s2 - s1 + 1;
//     }
//     int[] array = new int[n];
//     array[0] = s1;
//     int count = s2 - s1;
//     for (int i = 1; i <= count; i++)
//     {
//         array[i] = array[i - 1] + 1;
//     }
//     return array;
// }
// int NumberSum(int[] arr)
// {
//     int sum = 0;
//     int count = arr.Length;
//     for (int i = 0; i < count; i++)
//     {
//         sum = sum + arr[i];
//     }
//     return sum;

// }
// void PrintArray(int[] arr)
// {
//     int count = arr.Length;
//     Console.Write("[");
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{arr[i]}");
//         if (i < count - 1) Console.Write(", ");
//     }
//     Console.Write("]");
// }
// int numberM = NumberM();
// int numberN = NumberN();
// if (numberN > numberM)
// {
//     int[] arraySum = ArraySum(numberM, numberN);
//     PrintArray(arraySum);
//     int sum = NumberSum(arraySum);
//     Console.WriteLine();
//     Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} ->{sum}");
// }
// else
// {
//     int[] arraySum = ArraySum(numberN, numberM);
//     PrintArray(arraySum);
//     int sum = NumberSum(arraySum);
//     Console.WriteLine();
//     Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberN} до {numberM} ->{sum}");
// }


// int[] NumberNatural(int num)
// {
//     int[] array = new int[num];
//     array[0] = num;
//     int count=num;
//     for (int i = 1; i <count; i++)
//     {
//         array[i] = array[i-1]-1;
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     int count = arr.Length;
//     Console.Write("[");
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{arr[i]}");
//         if (i < count - 1) Console.Write(", ");
//     }
//     Console.Write("]");
// }
// int number = Number();
// if (number >0)
// {
// int[] numberNatural = NumberNatural(number);
// PrintArray(numberNatural);
// }
// else 
// {
//     Console.WriteLine("Ввели не натуральное число");
// }