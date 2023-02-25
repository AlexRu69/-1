// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9



Console.Clear();

double[,] GetArray2D(int a, int b, double minVolue, double maxVolue)
{
    double[,] array = new double[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = new Random().NextDouble() * (maxVolue - minVolue) - minVolue;
        }
    }
    return array;
}

void PrintAraay2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Введите кол-во строк: ");
int line = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
double[,] newArray = (GetArray2D(line, col, 1, 9));
PrintAraay2D(newArray);
System.Console.WriteLine();