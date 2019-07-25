using System;

static class StringHelper
{
    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}

class Program
{
    static void NotMain()
    {
        Console.WriteLine(StringHelper.ReverseString("Jordan"));
        Console.WriteLine(StringHelper.ReverseString("I love pizza"));
    }
}