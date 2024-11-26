using System;

class Program108
{
    static bool ChkAlphaCapi(char ch)
    {
        bool bFlag = false;

        if((ch >= 'A')&&(ch <= 'Z'))
        {
            bFlag = true;
        }
        return bFlag;
    }
    static void Main(string[] Argv)
    {
        bool bRet = false;

        Console.WriteLine("Enter the character : ");
        char cValue = char.Parse(Console.ReadLine());

        bRet = ChkAlphaCapi(cValue);

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