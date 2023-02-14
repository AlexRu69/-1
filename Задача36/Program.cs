// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int Addition(int[] Name)     
{
    int res = 0;
    for (int i = 1; i < Name.Length; i += 2)
    {
        res +=Name[i];
    }
    return res;
}

int[] array = GetArray(4, 1, 5);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine(Addition(array));