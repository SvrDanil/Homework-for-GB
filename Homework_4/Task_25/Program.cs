//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Square(int first,int second)
{
    int sum=1;
    for (int i= 0; i<second;i++)
    {
        sum=sum*first;
    }
    return sum;
}
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"{Square(a,b)}");

