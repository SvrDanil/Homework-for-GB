//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int count= 0;
if (a%2==0){Console.WriteLine(a);}
else {a=a-1;Console.WriteLine(a);}
while(a!=0){a=a-2;Console.WriteLine(a);}
