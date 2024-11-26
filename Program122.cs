using System;

class Program122
{
    static void StrUpperToLower(char[] str)
    {
        int Start = 0;
        int End = str.Length;

        while(Start < End)
        {
            if((str[Start] >= 'A')&&(str[Start] <= 'Z'))
            {   
                str[Start] = (char)(str[Start] + 32);
            }
            Start ++;
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] Output = Arr.ToCharArray();

        StrUpperToLower(Output);

        string Updated = new string(Output);

        Console.WriteLine(Updated);
    }
}