// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Строки и массивы использовать нельзя!

Console.WriteLine(" Введите цифру дня недели");
int num = int.Parse(Console.ReadLine());
int pol=0;
int numClone=num;
while(num>0)
{
    int digit = num%10;
    pol=pol*10+digit;
    num=num/10;
}
if (numClone==pol)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
