// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] RandomMatrixCreator(int x,int y)
{
    int[,] matrix = new int[x, y];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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
int [,] MatrixMultiplayer(int [,] firstMatrix,int[,] secondMatrix)
{
 int[,] resultMatrix=new int[firstMatrix.GetLength(0),secondMatrix.GetLength(1)];
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
    return resultMatrix;
}

Console.WriteLine("Введите размер число строк 1 матрицы");
int rows=int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов 1 и число строк 2 матрицы");
int collums=int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов 2 матрицы");
int rowsSecond=int.Parse(Console.ReadLine());
Console.WriteLine();
int [,] randomMatrix=RandomMatrixCreator(rows,collums);
int [,] randomMatrixSecond=RandomMatrixCreator(collums,rowsSecond);
PrintMatrix(randomMatrix);
Console.WriteLine();
PrintMatrix(randomMatrixSecond);
Console.WriteLine();
int [,]result =MatrixMultiplayer(randomMatrix,randomMatrixSecond);
Console.WriteLine();
PrintMatrix(result);