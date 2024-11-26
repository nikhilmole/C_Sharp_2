using System;

class Program109
{
    static bool ChkDigit(char ch)
    {
        bool bFlag = false;

        if((ch >= '0')&&(ch <= '9'))
        {
            bFlag = true;
        }
        return bFlag;
    }
    static void Main(String[] Argv)
    {
        bool bRet = false;

        Console.WriteLine("Enter the character : ");
        char cValue = char.Parse(Console.ReadLine());

        bRet = ChkDigit(cValue);
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