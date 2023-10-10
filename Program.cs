using System;

public delegate string AttachStringToEachOther(string s1, string s2);

class A
{
    public static string ConcatStrings(string s1, string s2)
    {
        return s1 + s2;
    }

    static void Main()
    {
        AttachStringToEachOther attachDelegate = ConcatStrings;

        string result = attachDelegate("Hello, ", "world!");

        Console.WriteLine("Concatenated String: " + result);
    }
}
