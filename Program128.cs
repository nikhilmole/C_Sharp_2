using System;

class Program128
{
    static int FreqChar(char[] str, char ch)
    {
        int iCount = 0;
        int Start = 0;
        int End = str.Length;

        while(Start < End)
        {
            if(str[Start] == ch)
            {
                iCount++;
            }
            Start++;
        }
        return iCount;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the string : ");
        string Arr = Console.ReadLine();

        char[] CharArr = Arr.ToCharArray();

        Console.WriteLine("Enter the Character : ");
        char ch = char.Parse(Console.ReadLine());

        int iRet = 0;

        iRet = FreqChar(CharArr,ch);
        Console.WriteLine(iRet);
    }
}