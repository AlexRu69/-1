// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B. Реализовать функцию возведения в степень
// самостоятельно!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

int Exponentiation(int A, int B)    //Метот принимает на вход два числа
{
    int sum = 1;     // Счётчик
    for (int i = 1; i <= B; i++)       //Пока диапозон от единицы до В выполнять
    {
        sum *= A;        //сумма = сумма * А
    }
    return sum;
}
// int Input(int A, int B)
// {
//     Console.Write("Введите первое число: ");
//     int num1 = int.Parse(Console.ReadLine()!);
//     Console.Write("Введите второе число: ");
//     int num2 = int.Parse(Console.ReadLine()!);
//     return num1;
//     return num2;
// }

//Input(num1, num2);
Console.Write(Exponentiation(num1, num2));

