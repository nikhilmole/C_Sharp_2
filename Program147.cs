using System;

class Program
{
    static int WordCount(char[] str)
    {
        int Start = 0;
        int End = str.Length - 1;
        int iCnt = 0;
        bool inword = false;
        if(End == 0)
        {
            return -1;
        }

        while(Start < End)
        {
            if(str[Start] == ' ')
            {
                inword = false;
            }
            else if(! inword)
            {
                inword = true;
                iCnt++;
            }
            Start++;
        }
        return iCnt;
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] CharArr = Arr.ToCharArray();

        int iRet = WordCount(CharArr);

        Console.WriteLine(iRet);
    }
}