using System;

class Program172
{
    static int iCount = 0;
    static int Start = 0;

    static int CountSmall(char[] str)
    {
        int End = str.Length;

        if(Start < End)
        {
            if(str[Start] >= 'a' && str[Start] <= 'z')
            {
                iCount++;
            }
            Start ++;
            CountSmall(str);
        }
        return iCount;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] CharArr = Arr.ToCharArray();

        int iRet = CountSmall(CharArr);
        Console.WriteLine(iRet);
    }
}