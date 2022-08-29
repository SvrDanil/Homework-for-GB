//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int num= int.Parse(Console.ReadLine());
int temp = 0;
while (temp<num)
{
    temp=temp+1;
    Console.WriteLine($"{temp*temp*temp}");
}