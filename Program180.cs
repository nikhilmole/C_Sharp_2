using System;
class Program180
{
    static int OffBit(int iNum)
    {
        int iResult = 0;
        int iMask = 0xFFFFFFBF;
        
        iResult = iMask & iNum;

        return iResult;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the  Number : ");
        int iNo = int.Parse(Console.ReadLine());

        int iRet  = OffBit(iNo);

        Console.WriteLine("Updated number is : "+iRet);
    }
}