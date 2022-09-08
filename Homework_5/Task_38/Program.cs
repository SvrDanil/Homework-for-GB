// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] Rnd(int N)
{
    int [] arr= new int[N];
    for (int i=0;i < arr.Length;i++)
    {
        arr[i]=new Random().Next(0,100);
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

int result(int [] arr1)
{       
    int min=arr1[0];
    int max=arr1[0];
    for (int i=0;i < arr1.Length;i++)
    {
        if (max<arr1[i])
        {
            max=arr1[i];
        }
        if (min>arr1[i]) 
        {
            min=arr1[i];
        }
    }
    int diff=max-min;
    return diff;
}
Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());

int[] constArr=Rnd(size);
WriteArr(constArr);


Console.WriteLine($" Разница = {result(constArr)}");