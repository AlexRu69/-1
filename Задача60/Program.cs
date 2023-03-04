// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.


Console.Clear();

int[,,] GetArray3D(int a, int b, int c, int minVolue, int maxVolue)  //Создание трёхмерного массива
{
    int[,,] array3D = new int[a, b, c];
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = new Random().Next(minVolue, maxVolue + 1);
            }
        }
    }
    return array3D;
}

void PrintArray3D(int[,,] array)  // Вывод трёхмерного массива построчно и постранично
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        //System.Console.WriteLine($"Страница # {i + 1}");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                //System.Console.Write($"{array[i, j, k]}\t ");
                System.Console.WriteLine($"{array[i, j, k]} [{i}{j}{k}]");

            }
            //System.Console.WriteLine();
        }
    }

}

int[,,] array3D = GetArray3D(3, 3, 3, 9, 100);
PrintArray3D(array3D);