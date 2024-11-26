using System;

class Program132
{
    static void StrCpy(char[] str, char[] dest)
    {
        int Start = 0;
        int End = str.Length;

        while(Start < End)
        {
            dest[Start] = str[Start];

            Start++;
        }
    }
    static void Main(string[] Argv)
    {
        string Arr = "Marvellous Multi Os";
        char[] Brr = new char[Arr.Length];

        char[] CharArr = Arr.ToCharArray();

        StrCpy(CharArr, Brr);

        string Updated = new string(Brr);
        Console.WriteLine("Copy String is : "+Updated);
    }
}