using System;

class Program190
{
    static uint Toggle(uint iNum, int iPos)
    {
        uint iMask = 0;
        uint iResult = 0;

        iMask = 1U << (iPos - 1);

        iResult = iMask ^ iNum;

        return iResult;
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        uint iNo = uint.Parse(Console.ReadLine());

        Console.WriteLine("Enetr the position : ");
        int iValue = int.Parse(Console.ReadLine());

        uint iRet = Toggle(iNo, iValue);
        Console.WriteLine("The updated number is : "+iRet);

    }
}