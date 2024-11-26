using System;

class Program137
{
    static void StrCpyRev(char[] str, char[] dest)
    {
        int Start = 0;
        int End = str.Length-1;

        while(0 <= End)
        {
            dest[Start] = str[End];

            Start++;

            End--;
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] CharArr = Arr.ToCharArray();

        char[] Brr = new char[Arr.Length];

        StrCpyRev(CharArr,Brr);

        Console.WriteLine(Brr);
    }
}