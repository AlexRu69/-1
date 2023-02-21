// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

System.Console.WriteLine("Введите числа через пробел: ");
string[] input = Console.ReadLine().Split();     //Получаем ввод с клавиатуры сразу в массив string
System.Console.WriteLine(string.Join(" ", input));
System.Console.WriteLine(CountPositive(ConvertStringToInt(input)));



int[] ConvertStringToInt(string[] Array)
{
    int[] intArryay = new int[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        intArryay[i] = int.Parse(Array[i]);    //Поэлиментно преобразовываем string в unt и записываем в новый массив
    }
    return intArryay;
}

int CountPositive(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) count++;     // Считаем кол-во чисел больше нуля
    }
    return count;
}