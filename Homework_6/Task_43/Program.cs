// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void crossPoint(double[,] matr)
{   
   
    if (matr[0,1]==matr[1,1])
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
         double x=(matr[1,0] - matr[0,0])/(matr[0,1] - matr[1,1]);
         double y= (matr[0,1]*x) + matr[0,0];
         Console.WriteLine($"x={x} y={y}");
    }   

}
double[,] arr =  new double[2,2];
Console.Write("Введите b1: ");
arr[0,0]= double.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
arr[0,1]= double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
arr[1,0]= double.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
arr[1,1]= double.Parse(Console.ReadLine());

crossPoint(arr);
