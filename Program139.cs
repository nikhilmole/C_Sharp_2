using System;

class Program139
{
    static void CopyconverUpper(char[] str, char[] dest)
    {
        int Start = 0;
        int End = str.Length;

        while(Start < End)
        {
            if((str[Start] >= 'A')&&(str[Start] <= 'Z'))
            {
                dest[Start] = str[Start];
            }
            if((str[Start] >= 'a')&&(str[Start] <= 'z'))
            {
                dest[Start] = (char)(str[Start] - 32);
            }
            else            
            {
                dest[Start] = str[Start];
            }

            Start++;
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] Brr = new char[Arr.Length];

        char[] CharArr = Arr.ToCharArray();

        CopyconverUpper(CharArr, Brr);

        Console.WriteLine(Brr);
    }
}