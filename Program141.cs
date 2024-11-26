using System;

class Program140
{
    static void Toggle(char[] str, char[] dest)
    {
        int Start = 0;
        int End = str.Length;

        while(Start < End)
        {
            if((str[Start] >= 'A')&&(str[Start] <= 'Z'))
            {
                dest[Start] = (char)(str[Start] + 32);
            }
            if((str[Start] >= 'a')&&(str[Start] <= 'z'))
            {
                dest[Start] = (char)(str[Start] - 32);
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

        Toggle(CharArr, Brr);

        Console.WriteLine(Brr);
    }
}