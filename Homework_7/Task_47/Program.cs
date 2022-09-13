// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int[,] MatrixCreator(int x, int y)
{
    int[,] matrix = new int[x, y];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите m ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n ");
int n = int.Parse(Console.ReadLine());
PrintMatrix(MatrixCreator(m, n));