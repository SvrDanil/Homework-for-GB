//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите 1 число");
int a= int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int b=int.Parse(Console.ReadLine());
if (a>b)
    {Console.WriteLine($"{a} Больше");}   
else
    {Console.WriteLine($"{b} Больше");}   