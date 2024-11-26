using System;

class Program174
{
    static int iRev = 0;
    static int Rev(int iNo)
    {
        int iDigit = 0;

        if(iNo > 0)
        {
            iDigit = iNo % 10;
            iRev = iRev * 10 + iDigit;
            iNo = iNo / 10;

            Rev(iNo);
        }
        return iRev;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the Number : ");
        int iNo = int.Parse(Console.ReadLine());

        int iRet = Rev(iNo);
        Console.WriteLine(iRet);
    }
}