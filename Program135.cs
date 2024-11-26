using System;

class Program135
{
    static void StrCpy(char[] str, char[] dest)
    {
        int Start = 0;
        int End = str.Length;
        int DestIndex = 0;

        while(Start < End)
        {
            if((str[Start] >= 'a')&&(str[Start] <= 'z'))
            {
                dest[DestIndex] = str[Start];
                DestIndex++;
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

        StrCpy(CharArr,Brr);

        string Updated = new string(Brr);

        Console.WriteLine("Small let us : "+Updated);
    }
}