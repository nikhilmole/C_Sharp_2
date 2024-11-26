using System;

class Program143
{
    static bool StrCmpX(string str, string dest)
    {
        if(str.Equals(dest))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main(string[] Argv)
    {
        bool bRet = false;

        Console.WriteLine("Enter the First String : ");
        string Arr = Console.ReadLine();

        Console.WriteLine("Enter the SecondString : ");
        string Brr = Console.ReadLine();

        bRet = StrCmpX(Arr,Brr);
        if(bRet == true)
        {
            Console.WriteLine("Strings Are Same");
        }
        else
        {
            Console.WriteLine("Strings Are not same");
        }
    }
}