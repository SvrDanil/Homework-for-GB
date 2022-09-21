// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int AkkermanFunc(int m,int n)
{
    int answer;
    if (m == 0) answer = n + 1;
    else if (n == 0) answer = AkkermanFunc(m - 1, 1);
    else answer = AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    return answer;
}
Console.WriteLine("Ведите m");
int M=int.Parse(Console.ReadLine());
Console.WriteLine("Ведите n");
int N=int.Parse(Console.ReadLine());
Console.WriteLine(AkkermanFunc(M,N));