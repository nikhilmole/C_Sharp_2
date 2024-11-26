using System;

class Program107
{
    static bool ChkAlpha(char ch)
    {
        bool bFlag = false;

        if((ch >= 'A')&&(ch <= 'Z')||(ch >= 'a')&&(ch <= 'z'))
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

        bRet = ChkAlpha(cValue);
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