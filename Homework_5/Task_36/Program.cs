// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] Rnd(int N)
{
    int [] arr= new int[N];
    for (int i=0;i < arr.Length;i++)
    {
        arr[i]=new Random().Next(-25,26);
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
        if (i%2!=0)
        {
            sum=sum+arr1[i];
        }
        
    }
    return sum;
}
Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());

int[] constArr=Rnd(size);
WriteArr(constArr);


Console.WriteLine($" Сумма = {count(constArr)}");
