// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

System.Console.Write("Ведите координату b1: ");
double b1 = double.Parse(Console.ReadLine()!);
System.Console.Write("Ведите координату k1: ");
double k1 = double.Parse(Console.ReadLine()!);
System.Console.Write("Ведите координату b2: ");
double b2 = double.Parse(Console.ReadLine()!);
System.Console.Write("Ведите координату k2: ");
double k2 = double.Parse(Console.ReadLine()!);

double GetX(double a, double b, double c, double d)
{
    double x;
    return x = (c - a) / (b - d);
}

double GetY(double i, double f, double x)
{
    double y;
    return y = i * x + f;
}

System.Console.WriteLine($"x = {GetX(b1, k1, b2, k2)}");
System.Console.WriteLine($"y = {GetY(k1, b1, GetX(b1, k1, b2, k2))}");