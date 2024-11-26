using System;

class Program117
{
    static int CountCapital(string str)
    {
        int iCount = 0;
        int index = 0;
        int Length = str.Length;

        while(index < Length)
        {
            if((str[index] >= 'A')&&(str[index] <= 'Z'))
            {
                iCount++;
            }
            index++;
        }
        return iCount;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        int iRet = CountCapital(Arr);

        Console.WriteLine("the capital numbers are : {0}",iRet);
    }
}