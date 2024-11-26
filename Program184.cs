using System;

class Program184
{
    static int ONBit(int iNum)
    {
        int iResult = 0;
        int iMask = 0x0F;

        iResult = iMask | iNum;
        
        return iResult;
    }

    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the Number : ");
        int iNo = int.Parse(Console.ReadLine());

        int iRet = ONBit(iNo);

        Console.WriteLine("The updated number is : "+iRet);
    }
}