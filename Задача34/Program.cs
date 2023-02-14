// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2


Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)      // minValue - мин значение/maxValue - максимальное/ size -размер массива
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);  //каждому элементумассива присваиваем значение
    }                                                           // от мин до макс значениий
    return array;
}

int CountPositive(int[] name)
{
    int count = 0;
    for (int i = 0; i < name.Length; i++)    //перебераем элементы массива и проверяем на чётность
    {
        if(name[i] % 2 == 0) count++;
    }
    return count;
}

int[] array = GetArray(10, 100, 999);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine(CountPositive(array));
