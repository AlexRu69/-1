// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9


Console.Clear();

double Akkerman(double m, double n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

System.Console.WriteLine("Введите число m: ");
double m = double.Parse(System.Console.ReadLine()!);
System.Console.WriteLine("Введите число n: ");
double n = double.Parse(System.Console.ReadLine()!);
System.Console.WriteLine(Akkerman(m, n));