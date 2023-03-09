// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int GetSek(int M, int N)
{
    // if (M == N) return $"{M}";
    // return $"{M}, " + GetSek(M + 1, N);
    if (M == N) return M;
    int res = GetSek(M, N - 1) + N;
    return res;
}


System.Console.WriteLine("Введите число M: ");
int m = int.Parse(System.Console.ReadLine()!);
System.Console.WriteLine("Введите число N: ");
int n = int.Parse(System.Console.ReadLine()!);
System.Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} равна ");
System.Console.WriteLine(GetSek(m, n));