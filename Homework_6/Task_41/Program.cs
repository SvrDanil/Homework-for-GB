//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[]  numbers(int count)
{   
    int [] arr= new int[count];
    for (int i = 0;i<count;i++)
    {
        Console.WriteLine("Введите число");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr ;
}

int counter(int[] arr1)
{
    int count=0;
    for (int i = 0;i<arr1.Length;i++)
    {
        if (arr1[i]>0)
        {
            count++;
        }
    }
    return count;

}
Console.WriteLine("Введите Число M");

int M = int.Parse(Console.ReadLine());

Console.WriteLine($"Чисел больше нуля :{counter(numbers(M))}");
