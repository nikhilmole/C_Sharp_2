using System;

class Program110
{
    static bool ChkCapitalorSmalll(char ch)
    {
        bool bFlag = false;

        if((ch >= 'a')&&(ch <= 'z'))
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

        bRet = ChkCapitalorSmalll(cValue);

        if(bRet == true)
        {
            Console.WriteLine("Small charecter");
        }
        else
        {
            Console.WriteLine("Capital character: ");
        }
    }
}