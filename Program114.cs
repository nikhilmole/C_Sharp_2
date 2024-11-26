using System;

class Protgram114
{
    static void Display(char ch)
    {
        int i = 0;

        if((ch >= 'A')&&(ch <= 'Z'))
        {
            for(i = ch; i <= 'Z'; i++)
            {
                Console.WriteLine((char)(i));
            }
        }
        else if((ch >= 'a')&&(ch <= 'z'))
        {
            for(i = ch; i <= 'z'; i++)
            {
                Console.WriteLine((char)(i));
            }
        }
        else
        {
            Console.WriteLine("Invalid option");
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the character : ");
        char cValue = char.Parse(Console.ReadLine());

        Display(cValue);
    }
}