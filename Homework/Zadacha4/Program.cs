//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите 1 число");
int a= int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int b=int.Parse(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int c=int.Parse(Console.ReadLine());
int max=a;
if (max<b){max=b;}
if (max<c){max=c;}
Console.WriteLine($"Самое большое ={max}");
  
  