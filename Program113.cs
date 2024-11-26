using System;

class Program113
{
    static void Convert(char ch)
    {
        if((ch >= 'A')&&(ch <= 'Z'))
        {
            Console.WriteLine((char)(ch + 32));
        }
        else if((ch >= 'a')&&(ch <= 'z'))
        {
            Console.WriteLine((char)(ch - 32));
        }
        else
        {
            Console.WriteLine(ch);
        }

    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the character : ");
        char cValue = char.Parse(Console.ReadLine());

        Convert(cValue);
    }
}