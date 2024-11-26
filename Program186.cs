using System;

class Program186
{
    static void CommonBits(uint iNum1, uint iNum2)
    {
        uint CommonBit = iNum1 & iNum2;
        uint Position = 0;

        while(CommonBit > 0)
        {
            if((CommonBit & 1) == 1)
            {
                Console.WriteLine("The common bits are : "+Position);
            }
            CommonBit >>= 1;
            Position ++;
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the First Number : ");
        uint iNo1 = uint.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Second Number : ");
        uint iNo2 = uint.Parse(Console.ReadLine());

        CommonBits(iNo1, iNo2);
    }
}