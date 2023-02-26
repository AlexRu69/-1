// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Clear();

int[,] GetArray2D(int a, int b, int minVolue, int maxVolue)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = new Random().Next(minVolue, maxVolue + 1);
        }
    }
    return array;
}

void PrintAraay2D(int[,] array)
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

void ShowCellContents(int[,] array, int a, int b)
{

    if (a > array.GetLength(0) || b > array.GetLength(1))
        System.Console.WriteLine("Такого элемента нет!");
    else
    {
        System.Console.WriteLine($"На этой позиции находится число {array[a, b]}");
    }
}


System.Console.Write("Введите кол-во строк: ");
int line = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите номер строки: ");
int numLine = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите номер столбца: ");
int numCol = int.Parse(Console.ReadLine()!);
int[,] newArray = (GetArray2D(line, col, 0, 9));
System.Console.WriteLine();
PrintAraay2D(newArray);
System.Console.WriteLine();
ShowCellContents(newArray, numLine, numCol);