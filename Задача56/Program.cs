// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов

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

int[] GetSum(int[,] matrix)   // считает сумму элементов строк [,]массива и записывает их в одномерный массив
{
    int[] sumString = new int[matrix.GetLength(0)];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        sumString[index++] = sum;

    }
    return sumString;
}

// int GetResult(int[] array)
// {

//     int res = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < res) res = array[i];
//     }
//     return res;
//     //System.Console.WriteLine($"Строка с наименьшей суммой элементов -> {res}");
// }

int[,] newAArray2D = GetArray2D(5, 3, 1, 9);
PrintAraay2D(newAArray2D);
GetSum(newAArray2D);
System.Console.WriteLine();
System.Console.WriteLine(string.Join(", ", GetSum(newAArray2D)));
System.Console.WriteLine();
int[] newArray = GetSum(newAArray2D);
// System.Console.WriteLine(GetResult(newArray));

int idx = Array.IndexOf(newArray, newArray.Min());    //Выдаёт индекс и значение минимальной строки.
Console.WriteLine($"index of min = {idx}, value of min = {newArray[idx]}");