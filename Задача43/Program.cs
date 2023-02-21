// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

System.Console.Write("Ведите координату b1: ");
int b1 = int.Parse(Console.ReadLine()!);
System.Console.Write("Ведите координату k1: ");
int k1 = int.Parse(Console.ReadLine()!);
System.Console.Write("Ведите координату b2: ");
int b2 = int.Parse(Console.ReadLine()!);
System.Console.Write("Ведите координату k2: ");
int k2 = int.Parse(Console.ReadLine()!);

double GetX(int a, int b, int c, int d)
{
    double x;
    return x = (c - a) / (b - d);
}

double GetY(int i, int f, double x)
{
    double y;
    return y = i * x - f;
}

System.Console.WriteLine($"x = {GetX(b1, k1, b2, k2)}");
System.Console.WriteLine($"y = {GetY(k1, b1, GetX(b1, k1, b2, k2))}");