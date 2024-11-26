using System;

class Program136
{
    static string StrCnt(string Str1, string Str2)
    {
        Str1 = Str1 + Str2;

        return Str1;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the First String");
        string Arr = Console.ReadLine();

        Console.WriteLine("Enter the Second String");
        string Brr = Console.ReadLine();

        string Updated = StrCnt(Arr, Brr);

        Console.WriteLine(Updated);
    }
}