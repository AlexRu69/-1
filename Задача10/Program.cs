// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого
// числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine()!);

// int a = num % 100;
// int b = a / 10;
// Console.Write(b);

int xxx(int n)
{
    int a = (n /10) % 10;
    return a;
}
Console.Write(xxx(num));