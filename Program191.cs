using System;

class Program191
{
    static uint OffBit(uint iNum, int iPos)
    {
        uint iMask = 0;
        uint iResult = 0;

        iMask = ~(1U << (iPos - 1));

        iResult = iMask & iNum;
        return iResult;
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the Number : ");
        uint iNo = uint.Parse(Console.ReadLine());

        Console.WriteLine("Ente the position : ");
        int iValue = int.Parse(Console.ReadLine());

        uint iRet = OffBit(iNo, iValue);

        Console.WriteLine("The Updated number is : "+iRet);
    }
}