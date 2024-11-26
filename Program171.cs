using System;

class Program171
{
    static int iMax = 0;

    static int Max(int iNo)
    {
        int iDigit = 0;

        if(iNo > 0)
        {
            iDigit = iNo % 10;
            if(iMax < iDigit)
            {
                iMax = iDigit;
            }
            iNo = iNo / 10;
            Max(iNo);
        }
        return iMax;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the Number : ");
        int iNo = int.Parse(Console.ReadLine());

        int iRet = Max(iNo);
        Console.WriteLine(iRet);
    }
}