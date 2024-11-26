using System;

class Program185
{
    static int CountOnBits(uint iNum)
    {
        int iCnt = 0;

        while(iNum > 0)
        {
            iCnt = iCnt + (int)(iNum & 1);
            iNum >>= 1;
        }
        return iCnt;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the Number : ");
        uint iNo = uint.Parse(Console.ReadLine());

        int iRet = CountOnBits(iNo);
        Console.WriteLine("The on bits are : "+iRet);
    }
}