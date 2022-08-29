// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите x первой точки");
int x1= int.Parse(Console.ReadLine());
Console.WriteLine("Введите y первой точки");
int y1= int.Parse(Console.ReadLine());
Console.WriteLine("Введите z первой точки");
int z1= int.Parse(Console.ReadLine());

Console.WriteLine("Введите x второй точки");
int x2= int.Parse(Console.ReadLine());
Console.WriteLine("Введите y второй точки");
int y2= int.Parse(Console.ReadLine());
Console.WriteLine("Введите z второй точки");
int z2= int.Parse(Console.ReadLine());

int sqr1=(x1-x2)*(x1-x2);
int sqr2=(y1-y2)*(y1-y2);
int sqr3 =( z1-z2)*(z1-z2);

int sum = sqr1+sqr2+sqr3;
double result = Math.Sqrt(sum);
Console.WriteLine($"Расстояние = {result:f2}");
