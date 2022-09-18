// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] RandomMatrixCreator()
{
    int y=new Random().Next(2, 5);
    int x =new Random().Next(2, 5);
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
int SumLine(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}
int MinSumFinder(int[,] matrix)
{
  int minSumLine = 0;
  int sumLine = SumLine(matrix, 0);
  for (int i = 1; i < matrix.GetLength(0); i++)
  {
  int tempSumLine = SumLine(matrix, i);
      if (sumLine > tempSumLine)
      {
    sumLine = tempSumLine;
    minSumLine = i;
      }
  }
  return minSumLine;
}
int [,] randomMatrix=RandomMatrixCreator();
PrintMatrix(randomMatrix);
Console.WriteLine();
Console.WriteLine($"№ Строки с наименьшей суммой {MinSumFinder(randomMatrix)+1}");