using System;


class Program183
{
    static uint ToggleBit(uint iNum)
    {
        uint iMask = 0x00000240;
        uint iResult = 0;

        iResult = iMask ^ iNum;

        return iResult;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the Number : ");
        uint iNo = uint.Parse(Console.ReadLine());

        uint iRet = ToggleBit(iNo);
        Console.WriteLine("The Updated number is : "+iRet);
    }
}