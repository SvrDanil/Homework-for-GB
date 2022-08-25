// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine(" Введите цифру дня недели");
int num = int.Parse(Console.ReadLine());
if (num<6) 
{
    Console.WriteLine("нет");
}
else if (num>5 && num<8)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("Не верный ввод");
}