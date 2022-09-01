// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Summa (int number)
{   
    int sum=0;
    while(number>0)
    {   
        
        int digit = number%10;
        number=number/10;
        sum=sum+digit;
    
    }
    return sum;
}
Console.WriteLine(" Введите число");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"{Summa(num)}");
