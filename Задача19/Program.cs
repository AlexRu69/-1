﻿// Задача 19: Напишите программу, которая принимает
// на вход пятизначное число и проверяет, является ли
// оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();

Console.Write("Введите число ");
int n = int.Parse(Console.ReadLine()!);

if ((n / 10000)==(n % 10) && ((n / 1000) % 10)==((n % 100) / 10))
{
    Console.Write("Yes");
}
else
{
    Console.Write("no");
}