using System;

class Program131
{
    static void Rev(char[] str)
    {
        int Start = 0;
        int End = str.Length - 1;
        char temp = '\0';

        while(Start < End)
        {
            temp = str[End];
            str[End] = str[Start];
            str[Start] = temp;

            Start++;
            End--;
        }
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] CharArr = Arr.ToCharArray();

        Rev(CharArr);
        Console.WriteLine(CharArr);
    }
}