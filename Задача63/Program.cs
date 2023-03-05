// Задача 63: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

// string GetSek(int N)
// {
//     if (N == 1) return $" {N}";
//     return GetSek(N - 1) + $", {N}";
// }

// System.Console.WriteLine(GetSek(5));

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// string GetSek(int M, int N)
// {
//     // if (M == N) return $"{M}";
//     // return $"{M}, " + GetSek(M + 1, N);
//     if (M == N) return $" {M}";
//     return GetSek(M, N - 1) + $", {N}";
// }

// System.Console.WriteLine(GetSek(5, 25));

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int GetSum(int N)
// {
//     if (N == 0) return 0;
//     return N % 10 + GetSum(N / 10);
// }
// System.Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine(GetSum(n));

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 

int GetDeg(int A, int B)
{
    if (B == 0) return 1;
    return A * GetDeg(A, B-1);
}

System.Console.WriteLine(GetDeg(3, 5));