using System;

class Program121
{
    static void Reverse(char[] str)
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
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the string : ");
        string Arr = Console.ReadLine();

        char[] CharArray = Arr.ToCharArray();

        Reverse(CharArray);

        string Reve = new string(CharArray);

        Console.WriteLine(Reve);
    }
}