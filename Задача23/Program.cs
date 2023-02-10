// Задача №19. Общее обсуждение
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел
// от 1 до N.


Console.Clear();

Console.Write("Введите число N: ");
double N = double.Parse(Console.ReadLine()!);
double count = 1;
while (count <= N)
{
                                   //2
    Console.Write($"{Math.Pow(count, 3)}");
    if (count != N)
    {
        Console.Write(", ");
    }
    //Console.Write($"{count * count},");
    count++;
}