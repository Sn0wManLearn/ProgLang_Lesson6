// Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.
using System;

class MyClass
{
    public static void Main()
    {
        string str = "HeLlO WoRlD!";

        Console.WriteLine(str);

        str = str.ToLower();

        Console.WriteLine(str);
    }
}
