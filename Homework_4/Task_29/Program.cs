// Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.
int[] Rnd(int N,int a,int b)
{
    int [] arr= new int[N];
    for (int i=0;i < arr.Length;i++)
    {
        arr[i]=new Random().Next(a,b);
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

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Веедите нижнюю границу массива");
int lower = int.Parse(Console.ReadLine());
Console.WriteLine("Веедите верхнюю границу массива");
int upper = int.Parse(Console.ReadLine());

WriteArr(Rnd(size,lower,upper));
