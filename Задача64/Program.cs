﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Clear();

string GetSek(int N)
{
if (N == 1) return $"{N}";
return $"{N}, " + GetSek(N - 1);
}

System.Console.WriteLine("Введите число N: ");
int n = int.Parse(System.Console.ReadLine()!);
System.Console.WriteLine(GetSek(n));