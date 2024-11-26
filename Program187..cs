using System;

class Program187
{
    static bool OnorOff(uint iNum)
    {
        uint iResult = 0;
        uint iMask = 2304;

        iResult = iMask & iNum;

        if(iResult == iMask)
        {
            return true;
        }
        return false;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the Number : ");
        uint iNo = uint.Parse(Console.ReadLine());

        bool bRet = false;

        bRet = OnorOff(iNo);
        if(bRet == true)
        {
            Console.WriteLine("The 9th and 12th bit is on");
        }
        else
        {
            Console.WriteLine("The 9th and 12th bit is off");
        }
    }
}