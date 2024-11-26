using System;

class Program170
{
    static int iCount = 0;
    static int Start = 0;
    static int CountWhite(char[] str)
    {
        int End = str.Length;

        if(Start < End)
        {
            if(str[Start] == ' ')
            {
                iCount++;
            }
            Start++;
            CountWhite(str);
        }
        return iCount;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] CharArr = Arr.ToCharArray();

        int iRet = CountWhite(CharArr);
        Console.WriteLine(iRet);
    }
}