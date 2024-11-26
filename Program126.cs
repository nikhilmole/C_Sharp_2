using System;

class Program126
{
    static int CountWhiteSpaces(char[] str)
    {
        int Start = 0;
        int End = str.Length;
        int iCount = 0;

        while(Start < End)
        {
            if(str[Start] == ' ')
            {
                iCount++;
            }
            Start++;
        }
        return iCount;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] CharArr = Arr.ToCharArray();

        int iRet = CountWhiteSpaces(CharArr);

        Console.WriteLine("White Spaces Count is : "+iRet);
    }
}