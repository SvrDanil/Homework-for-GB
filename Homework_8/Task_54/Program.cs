//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] RandomMatrixCreator()
{
    int y=new Random().Next(2, 10);
    int x =new Random().Next(2, 10);
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
    return;
}
int[,] MatrixSorter(int[,] matrix) 
{   

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
      
                if (matrix[i, k] < matrix[i, k + 1])
                {
                int temp = matrix[i, k + 1];
                matrix[i, k + 1] = matrix[i, k];
                matrix[i, k] = temp;
                }
            }
        }
    }
    return matrix;
}
int [,] randomMatrix=RandomMatrixCreator();
PrintMatrix(randomMatrix);
Console.WriteLine();
Console.WriteLine("Отсортированная матрица:");

PrintMatrix(MatrixSorter(randomMatrix));

