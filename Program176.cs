using System;

class Program176
{
    static bool ChkBit(int iNum)
    {
        int iResult = 0;
        int iMask = 16400;

        iResult = iNum & iMask;

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
            Console.WriteLine("The 5 and 15 bit is on");
        }
        else
        {
            Console.WriteLine("The 5 and 15 bit is off");
        }
    }
}