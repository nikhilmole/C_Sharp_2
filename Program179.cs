using System;

class Program179
{
    static bool ChkBit(int iNum)
    {
        int iResult = 0;
        int iMask = 2147483649;

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

        Console.WriteLine("Enter the Number : ");
        int iNo = int.Parse(Console.ReadLine());

        bRet = ChkBit(iNo);
        if(bRet == true)
        {
            Console.WriteLine("The 1 and 32 bit is on ");
        }
        else
        {
            Console.WriteLine("The 1 and 32 bit is off ");
        }
    }
}