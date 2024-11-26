using System;

class Program167
{
    static int Strlen(char[] str)
    {
        return str.Length;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String :");
        String Arr = Console.ReadLine();

        char[] CharArr = Arr.ToCharArray();

        int iRet = Strlen(CharArr);
        Console.WriteLine("The String length is : "+iRet);
    }
}