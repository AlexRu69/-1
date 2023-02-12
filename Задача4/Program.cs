// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

Console.Write("Введите первое число ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число ");
int num3 = int.Parse(Console.ReadLine()!);

int max = number1;

if (number1 < number2)
{
    max = number2;
}
if (number2 < number3)
{
    max = number3;
}

Console.WriteLine($"{max }");

// void GetMax(int a, int b, int c)    Не получается создать метод сортировки пузырьком
// {
//     int[] array = new int[3];
//     int max = 0;
//     for (int i = 0; i < 2; i++)
//     {
//         if (array[i] > array[i + 1])
//         {
//             max = array[i];
//             array[i] = array[i + 1];
//             array[i + 1] = max;
//         }
//         Console.Write(max);
//     }
// }
// GetMax(num1, num2, num3);

