using System;

class Program177
{
    static bool ChkBit(int iNum)
    {
        int iResult = 0;
        int iMask = 135282752;

        iResult = iMask & iNum;

        if(iResult == iMask)
        {
            return true;
        }

        return false;
    }
    static void Main(string[] Argv)
    {
        bool bRet = false;

        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        bRet = ChkBit(iNo);

        if(bRet == true)
        {
            Console.WriteLine("5 15 21 28 bit is on ");
        }
        else
        {
            Console.WriteLine("5 15 21 28 bit is off ");
        }
    }
}