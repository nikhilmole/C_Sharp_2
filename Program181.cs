using System;

class Program181
{
    static uint OffBit(uint iNum)
    {
        uint iResult = 0;
        uint iMask = 0xFFFFFDBF;

        iResult = iMask & iNum;

        return iResult;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        uint iNo = uint.Parse(Console.ReadLine());

        uint iRet = OffBit(iNo);
        Console.WriteLine("Updated number is : "+iRet);
    }
}