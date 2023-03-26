// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

int[,] DivMatrix(int[,] matr1, int[,] matr2)
{
    int[,] matr3 = new int[matr1.GetLength(0), matr2.GetLength(1)];
    if (matr1.GetLength(1) == matr2.GetLength(0))
    {
        for (int i = 0; i < matr3.GetLength(0); i++)
        {
            for (int j = 0; j < matr3.GetLength(1); j++)
            {
                matr3[i, j] = 0;
                for (int n = 0; n < matr1.GetLength(1); n++)
                {
                    matr3[i, j] += matr1[i, n] * matr2[n, j];
                }
            }
        }
    }
    return matr3;
}
int[,] matrix1 = CreateMatrixRndInt(2, 2, 0, 10);
int[,] matrix2 = CreateMatrixRndInt(2, 2, 0, 10);
Console.WriteLine("  Матрица 1");
PrintMatrix(matrix1);
Console.WriteLine("  Матрица 2");
PrintMatrix(matrix2);
Console.WriteLine($"Результирующая матрица");
int[,] matrix3 = DivMatrix(matrix1, matrix2);
PrintMatrix(matrix3);
Console.ReadKey();
