using System;


class Program118
{
    static int CountSmall(string str)
    {
        int iCount = 0;
        int Index = 0;
        int Length = str.Length;

        while(Index < Length)
        {
            if((str[Index] >= 'a')&&(str[Index] <= 'z'))
            {
                iCount++;
            }
            Index++;
        }
        return iCount;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the string : ");
        string Arr = Console.ReadLine();

        int iRet = CountSmall(Arr);

        Console.WriteLine("The small numbers are : {0}",iRet);
    }
}