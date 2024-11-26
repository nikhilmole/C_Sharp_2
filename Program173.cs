using System;


class Program173
{
    static int iMin = 9;
    static int Min(int iNo)
    {
        int iDigit = 0;

        if(iNo > 0)
        {
            iDigit = iNo % 10;
            if(iDigit < iMin)
            {
                iMin  = iDigit;
            }
            iNo = iNo / 10;

            Min(iNo);
        }

        return iMin;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        int iRet = Min(iNo);
        Console.WriteLine(iRet);
    }
}