using System;

class Program115
{
    static bool ChkSymbol(char ch)
    {
        bool bFlag = false;

        if((ch == '!')||(ch == '@')||(ch == '#')||(ch == '$')||(ch == '%')||(ch == '^')||(ch == '&')||(ch == '*'))
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

        bRet = ChkSymbol(cValue);

        if(bRet == true)
        {
            Console.WriteLine("It is a special symbol");
        }
        else
        {
            Console.WriteLine("It is not a special symbol");
        }
    }
}