using System;

class Program134
{
    static void StrCpy(char[] str, char[] dest)
    {
        int Start = 0;
        int End = str.Length;

        while(Start < End)
        {
            if((str[Start] >= 'A')&&(str[Start] <= 'Z'))
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

        StrCpy(CharArr, Brr);

        string updated = new string(Brr);

        Console.WriteLine("Capital string is : "+updated);
    }
}