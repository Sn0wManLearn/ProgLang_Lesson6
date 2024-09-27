//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
using System;

class MyClass
{
    public static void Main()
    {
        char[,] arr = CreateCharArr(1, 7);

        string str = CharToString(arr);

        Console.WriteLine(str);
    }
    static char[,] CreateCharArr(int hight, int widht)
    {
        char[,] charArr = new char[hight, widht];
        Random random = new Random();
        for (int i = 0; i < hight; i++)
        {
            for (int j = 0; j < widht; j++)
            {
                charArr[i, j] = (char)random.Next(40, 90);
            }
        }
        return charArr;
    }

    static string CharToString(char[,] arr)
    {
        string str = "";
        foreach (char c in arr)
        {
            str += c;
        }
        return str;
    }
}