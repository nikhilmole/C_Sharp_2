using System;

class Program190
{
    static bool ChkBit(uint iNum, int iPos)
    {
        uint iMask = 0;
        uint iResult = 0;

        iMask = 1U << (iPos - 1);

        iResult = iMask & iNum;

        if(iMask == iResult)
        {
            return true;
        }
        return false;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the Number : ");
        uint iNo = uint.Parse(Console.ReadLine());

        Console.WriteLine("Enter the position of bit : ");
        int iValue = int.Parse(Console.ReadLine());

        bool bRet = false;

        bRet = ChkBit(iNo, iValue);
        if(bRet == true)
        {
            Console.WriteLine("ON");
        }
        else
        {
            Console.WriteLine("OFF");
        }
    }
}