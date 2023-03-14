//Напишите программу которая из имеющегося массива строк создаёт
//  массив в котором все строки меньше иле ровны
// трём символам. 

Console.Clear();

string[] str = { "hello", "123", "string", "5", ",.&", "homework" };
int index = 0;


//string[] GetArrayWhoseElementAreLessThan3Char(string[] array)

while (index < str.Length)
{
    string a = str[index];
    if (a.Length <= 3)
    {
        str[index] = a;
        index++;
        System.Console.WriteLine(str[index]);
    }
}


