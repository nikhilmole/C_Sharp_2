using System;

class Program148
{   
    static int MaxWordCount(char[] str)
    {
        int CurrentCount = 0;
        int MaxCount = 0;
        int Start = 0;
        int End = str.Length;

        while(Start < End)
        {
            if(str[Start] == ' ' || Start == End)
            {
                if(CurrentCount > MaxCount)
                {
                    MaxCount = CurrentCount;
                }
                CurrentCount = 0;
            }
            else
            {
                CurrentCount++;
            }
            Start++;
        }

        if(CurrentCount > MaxCount)
        {
            MaxCount = CurrentCount;
        }

        return MaxCount;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] CharArr = Arr.ToCharArray();

        int iRet = MaxWordCount(CharArr);

        Console.WriteLine(iRet);
    }
}