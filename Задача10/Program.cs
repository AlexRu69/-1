// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого
// числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
int input()
{
    Console.Write("Введите трёхзначное число: ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

// int a = num % 100;
// int b = a / 10;
// Console.Write(b);

int xxx(int input)
{
    int a = (input / 10) % 10;
    return a;
}

Console.Write(xxx(input()));

