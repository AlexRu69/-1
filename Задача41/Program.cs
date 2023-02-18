// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();




int[] GetArray(string num)     // Метод создания массива через ручной ввод(Строку)
{
    int[] array = new int[num.Length];
    for (int i = 0; i < num.Length; i++)
    {
        array[i] = num[i];
    }
    return array;
}



int GetSum(int[] array)
{
    int[] numbers = new int[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(numbers[i] > 0) count++;
        
    }
    return count;
}

 Console.Write("Введите числа через запятую: ");
 string numbers = Console.ReadLine();
 int[] Array = GetArray(numbers);
 Console.Write(GetSum(Array)!);