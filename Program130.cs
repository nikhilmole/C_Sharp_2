using System;

class Program130
{
    static int FirstOcc(char[] str, char ch)
    {
        int Start = 0;
        int End = str.Length;
        int iPose = -1;
        int iFreq = 1;

        while(Start < End)
        {
            if(str[Start] == ch)
            {
                iPose = iFreq;
            }
            Start++;
            iFreq++;
        }
        return iPose;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] CharArr = Arr.ToCharArray();

        Console.WriteLine("Enter the Character : ");
        char ch = char.Parse(Console.ReadLine());

        int iRet = FirstOcc(CharArr, ch);
        Console.WriteLine("The first occ is : "+iRet);
    }
}