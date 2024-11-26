using System;

class Program138
{   
    static void WhiteReoval(char[] str, char[] dest)
    {
        int Start = 0;
        int End = str.Length;
        int destIndex = 0;

        while(Start < End)
        {
            if(str[Start] != ' ')
            {
                dest[destIndex] = str[Start];

                destIndex ++;
            }
            Start ++;
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] Brr = new char[Arr.Length];

        char[] CharArr = Arr.ToCharArray();

        WhiteReoval(CharArr, Brr);

        Console.WriteLine(Brr);
    }
}