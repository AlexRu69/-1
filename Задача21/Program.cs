// Задача 21: Напишите программу, которая принимает
// на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.


Console.Clear();

Console.Write("Введите координату x0: ");
double x0 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату y0: ");
double y0 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату z0: ");
double z0 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату x1: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату y1: ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату z1: ");
double z1 = double.Parse(Console.ReadLine()!);

double A = Math.Pow(x1 - x0, 2) + Math.Pow(y1 - y0, 2) + Math.Pow(z1 - z0, 2);

double result = Math.Sqrt(A);

Console.WriteLine($"{result:f2}");   //f2 оставляет 2 знака после запятой
