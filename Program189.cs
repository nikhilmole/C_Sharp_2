using System;

class Program189
{
    static uint ToggleBit(uint iNum, int iStart, int iEnd)
    {
        uint iResult = 0;
        uint iMask = 0;
        int i = 0;

        for(i = iStart; i <= iEnd; i++)
        {
            iMask = (1U << (i - 1));
        }

        iResult = iMask ^ iNum;

        return iResult;

    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        uint iNo = uint.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Starting position : ");
        int iValue1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Ending position : ");
        int iValue2 = int.Parse(Console.ReadLine());

        uint iRet = ToggleBit(iNo, iValue1, iValue2);
        Console.WriteLine(iRet);
    }
}