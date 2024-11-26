using System;

class Program125
{   
    static void DisplayDigit(char[] str)
    {
        int Start = 0;
        int End = str.Length;

        while(Start < End)
        {
            if((str[Start] >= '0')&&(str[Start] <= '9'))
            {
                Console.WriteLine(str[Start]);
            }
            Start++;
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] CharArray = Arr.ToCharArray();

        DisplayDigit(CharArray);

    }
}