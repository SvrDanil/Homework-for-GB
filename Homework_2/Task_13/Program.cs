//Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет. 
Console.WriteLine("Введите число");
int num= int.Parse(Console.ReadLine());
if(num<100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int a=((num%1000)/100);
    Console.WriteLine($"{a}");
}