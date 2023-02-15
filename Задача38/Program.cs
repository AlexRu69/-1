// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

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

int GetSum(int[] Name)
{
    int res = 0;
    int max = 0;
    int min = 0;
    for(int index = 0; index < Name.Length; index++)
    {
        min = Name[0];
        if(Name[index] > max)
        {
            max = Name[index];
        }
        if(Name[index] < min)
        {
            min = Name[index];
        } 
        res = max - min;
    }
    return res;
}

int[] Array = GetArray(4, 1, 9);
System.Console.WriteLine(string.Join(", ", Array));
System.Console.WriteLine(GetSum(Array));