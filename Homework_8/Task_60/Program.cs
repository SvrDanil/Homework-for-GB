// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] ArrayCreator(int X,int Y,int Z)
{  
int[,,] Array3D = new int[X, Y, Z];
int[] temp = new int[Array3D.GetLength(0) * Array3D.GetLength(1) * Array3D.GetLength(2)];
int  number;
for (int i = 0; i < temp.GetLength(0); i++)
  {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
     {
        for (int j = 0; j < i; j++)
        {
         while (temp[i] == temp[j])
        {
            temp[i] = new Random().Next(10, 100);
            j = 0;
            number = temp[i];
        }
            number = temp[i];
        }
     }
    int count = 0; 
    for (int x = 0; x < Array3D.GetLength(0); x++)
     {
         for (int y = 0; y < Array3D.GetLength(1); y++)
            {
                for (int z = 0; z < Array3D.GetLength(2); z++)
                {
                 Array3D[x, y, z] = temp[count];
                 count++;
                }
            }
        }
    }
    return Array3D;
}
void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
Console.WriteLine("Введите X");
int x=int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y");
int y=int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z");
int z=int.Parse(Console.ReadLine());
WriteArray(ArrayCreator(x,y,z));