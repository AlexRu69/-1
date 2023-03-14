//Напишите программу которая из имеющегося массива строк создаёт
//  массив в котором все строки меньше иле ровны
// трём символам. 

Console.Clear();

string[] str = { "hello", "123", "string", "5", ",.&", "homework" };


// for (int i = 0; i < str.Length; i++)
// {
//     string element = str[i];
//     int index = 0;
//     if(element)
// }

string[] GetNewArray(string[] array)
{
    string[] str2 = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        string temp = array[i];
        int n = temp.Length;
        for (int j = 0; j < str2.Length; j++)
        {
            if (n <= 3)
            str2[j] = temp;
        }
    }
    return str2;
}

string[] result = GetNewArray(str);
System.Console.WriteLine(result);