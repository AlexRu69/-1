// // Задача 68: Напишите программу вычисления функции Аккермана с помощью
// // рекурсии. Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 9


// Console.Clear();

// double Akkerman(double m, double n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return Akkerman(m - 1, 1);
//     return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// System.Console.WriteLine("Введите число m: ");
// double m = double.Parse(System.Console.ReadLine()!);
// System.Console.WriteLine("Введите число n: ");
// double n = double.Parse(System.Console.ReadLine()!);
// System.Console.WriteLine(Akkerman(m, n));

string[] originalArray = { "hello", "world", "1598", "a", "b" };
string[] newArray = new string[originalArray.Length];
int count = 0;

for (int i = 0; i < originalArray.Length; i++)
{
    if (originalArray[i].Length <= 3)
    {
        newArray[count] = originalArray[i];
        count++;
    }
}

Array.Resize(ref newArray, count);
System.Console.WriteLine(newArray[count]);