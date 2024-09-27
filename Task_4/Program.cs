// Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.
using System;
class MyClass
{
    public static void Main()
    {
        string input = Console.ReadLine();

        string[] strings = input.Split(' ');

        string result = "";

        for (int i = strings.Length - 1; i >= 0; i--)
        {
            result += strings[i] + " ";
        }

        Console.WriteLine(result);
    }
}
