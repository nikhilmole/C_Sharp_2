using System;

class Program188
{
    static bool ChkBit(uint iNum, int iPos1, int iPos2)
    {
        uint iMask1 = 1U << (iPos1 - 1);
        uint iMask2 = 1U << (iPos2 - 1);

        uint iResult1 = iMask1 & iNum;
        uint iResult2 = iMask2 & iNum;

        if((iMask2 == iResult1)&&(iMask2 == iResult2))
        {
            return true;
        }

        return false;
    }
    static void Main(string[] Argv)
    {
        bool bRet = false;

        Console.WriteLine("Enter the Number : ");
        uint iNo = uint.Parse(Console.ReadLine());

        Console.WriteLine("Enter the First position : ");
        int iNum1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second position : ");
        int iNum2 = int.Parse(Console.ReadLine());

        bRet = ChkBit(iNo, iNum1, iNum2);
        if(bRet == true)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}