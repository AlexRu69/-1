//Напишите программу которая из имеющегося массива строк создаёт
//  массив в котором все строки меньше иле ровны
// трём символам. 

Console.Clear();

string[] originalArray = { "hello", "123", "string", "5", ",.&", "homework" };



string[] GetNewArray(string[] array)
{
    int size = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j].Length <= 3);
        size++;
    }

    string[] newArray = new string[size];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
        // string temp = array[i];
        // int n = temp.Length;
        // for (int j = 0; j < str2.Length; j++)
        // {
        //     if (n <= 3)
        //     str2[j] = temp;
        // }
    }
    return newArray;
}

void PrintArray(string[] inarray) // Метод вывода массива
{
    for (int i = 0; i  <inarray.Length; i++)
    {
        Console.Write($"{inarray[i]} ");
    }
}

string[] result = GetNewArray(originalArray);
PrintArray(result);


