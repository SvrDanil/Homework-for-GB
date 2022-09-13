// Задача 50. Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, и возвращает индексы этого элемента или же указание, что такого элемента нет.
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
}
void NumberSeeker(int[,] matr,int num)
{   
    bool exist=false;
      for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j]==num)
            {
                Console.WriteLine($"Строка {i+1} Столбец {j+1}");
                exist=true;
            }
            
        }
        
    }
    if(exist==false){Console.WriteLine("Такого числа нет");}
}
Console.WriteLine("Введите Число");
int number = int.Parse(Console.ReadLine());
int [,] randomMatrix=RandomMatrixCreator();
PrintMatrix(randomMatrix);
NumberSeeker(randomMatrix,number);