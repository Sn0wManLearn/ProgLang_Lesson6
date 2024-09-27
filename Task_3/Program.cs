//Задайте произвольную строку. Выясните, является ли она палиндромом.
using System;
class MyClass
{
    public static void Main()
    {
        string input = Console.ReadLine();
        input = input.Replace(" ", "");
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        string str2 = new string(chars);
        if (input == str2) Console.WriteLine("Строка палиндром.");
        else Console.WriteLine("Строка непалиндром.");
    }
}