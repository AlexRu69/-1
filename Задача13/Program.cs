// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine()!);

if (num < 100)
{
    Console.Write("Третьей цыфры нет");
}

if (num > 99 && num <1000)
{
Console.Write(num % 10);
} 

if (num > 999)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int result = num % 10;
}
Console.Write(result);
