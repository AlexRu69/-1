﻿// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine()!);

int A = 2;

while (A <= N)
{
    Console.WriteLine($"{A }");
    A = A + 2;
}