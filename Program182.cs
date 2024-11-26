using System;

class Program182
{
    static uint Toggle(uint iNum)
    {
        uint iResult = 0;
        uint iMask = 0x00000040;

        iResult = iMask ^ iNum;

        return iResult;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        uint iNo = uint.Parse(Console.ReadLine());

        uint iRet = Toggle(iNo);
        Console.WriteLine("The updated number is : "+iRet);
    }
}