using System;

class Program140
{
    static void StrCpySmallCopy(char[] str, char[] dest)
    {
        int Start = 0;
        int End = str.Length;

        while(Start < End)
        {
            if((str[Start] >= 'A')&&(str[Start] <= 'Z'))
            {
                dest[Start] = (char)(str[Start] + 32);
            }
            if((str[Start] >= 'a')&&(str[Start] <= 'z'))
            {
                dest[Start] = (char)str[Start];
            }
            else
            {
                dest[Start] = str[Start];
            }
            Start++;
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] Brr = new char[Arr.Length];

        char[] CharArr = Arr.ToCharArray();

        StrCpySmallCopy(CharArr, Brr);

        Console.WriteLine(Brr);
    }
}