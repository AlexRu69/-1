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

void GetSum(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int index = 0;
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int res = array[i,j];
            res = res + array[i,j];
            result[index++] = res;
        }
    }
    return result;
}

int[,] newAArray = GetArray2D(5, 5, 1, 3);
PrintAraay2D(newAArray);
int[] sumString = GetSum(newAArray);
System.Console.WriteLine(string.Join(", ", sumString));