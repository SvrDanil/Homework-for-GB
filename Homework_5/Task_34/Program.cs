// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] Rnd(int N)
{
    int [] arr= new int[N];
    for (int i=0;i < arr.Length;i++)
    {
        arr[i]=new Random().Next(100,1000);
    }

    return arr;
}
void WriteArr(int [] arr1)
{
     for (int i=0;i < arr1.Length;i++)
    {
        Console.Write($"{arr1[i]},");
    }
}

int count(int [] arr1)
{   
    int sum=0;
    for (int i=0;i < arr1.Length;i++)
    {
        if (arr1[i]%2==0)
        {
            sum=sum+1;
        }
        
    }
    return sum;
}
Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());

int[] constArr=Rnd(size);
WriteArr(constArr);



Console.WriteLine($" Чётных = {count(constArr)}");




