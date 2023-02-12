// Задача 27: Напишите функцию и запустите ее, которая
// принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);

int Sum(int A)
{
    int sum = 0;
    for (; A > 0; A /= 10)
    {
        sum = sum + A % 10;
    }
    return sum;
}
Console.Write(Sum(num1));