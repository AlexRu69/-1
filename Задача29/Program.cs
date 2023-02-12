// Задача 29: Напишите программу, которая задаёт массив из 8
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] GetArrya()   // Метод заданния массива (ручной ввод)
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число: ");
        int A = int.Parse(Console.ReadLine()!);
        array[i] = A;
    }
    return array;
}

void PrintArray(int[] inarray)  // Метод вывода массива
{
    for (int i = 0; i < inarray.Length; i++)
    {
        Console.Write($"{inarray[i]} ");
    }
}

int[] A = GetArrya();
Console.Write("[");
PrintArray(A);
Console.Write("]");
