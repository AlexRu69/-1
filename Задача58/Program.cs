// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

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

int[,] GetComposition(int[,] array, int[,] array2)  // Метод поиска произведения матриц
{
    int[,] composition = new int[array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                composition[i, j] += array[i, k] * array2[k, j];
            }
        }
    }
    return composition;
}

int[,] newArray = GetArray2D(3, 3, 1, 9);
int[,] newArray2 = GetArray2D(3, 3, 1, 9);
PrintAraay2D(newArray);
System.Console.WriteLine();
PrintAraay2D(newArray2);
System.Console.WriteLine();
int[,] resMatrix = GetComposition(newArray, newArray2);
PrintAraay2D(resMatrix);

