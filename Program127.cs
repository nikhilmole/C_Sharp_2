using System;

class Program127
{
    static bool ChkChar(char[] str, char ch)
    {
        bool bFlag = false;
        int Start = 0;
        int End = str.Length;

        while(Start < End)
        {
            if(str[Start] == ch)
            {
                bFlag = true;
            }
            Start++;
        }
        return bFlag;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] charArr = Arr.ToCharArray();

        Console.WriteLine("Enter the Character : ");
        string ch = Console.ReadLine();

        char Sch = ch[0];

        bool bRet = false;

        bRet = ChkChar(charArr, Sch);

        if(bRet == true)
        {
            Console.WriteLine("The character is present");
        }
        else
        {
            Console.WriteLine("The character is not present");
        }
    }
}