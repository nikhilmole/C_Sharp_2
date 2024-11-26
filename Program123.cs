using System;

class Program123
{
    static void StrLowerToUpper(char[] str)
    {
        int Start = 0;
        int End = str.Length;

        while(Start < End)
        {
            if((str[Start] >= 'a')&&(str[Start] <= 'z'))
            {
                str[Start] = (char)(str[Start] - 32);
            }
            Start++;
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] ArrChar = Arr.ToCharArray();

        StrLowerToUpper(ArrChar);

        string StrArr = new string(ArrChar);

        Console.WriteLine(StrArr);
    }
}