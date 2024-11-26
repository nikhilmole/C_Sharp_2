using System;

class Program178
{
    static bool ChkBit(int iNum)
    {
        int iResult = 0;
        int iMask = 488;

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
            Console.WriteLine("The 7 8 9 bit is on");
        }
        else
        {
            Console.WriteLine("The 7 8 9 bit is off");
        }
    }
}