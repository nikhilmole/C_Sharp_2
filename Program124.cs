using System;

class Program124
{
    static void Toggle(char[] str)
    {
        int Start = 0;
        int End = str.Length;

        while(Start < End)
        {
            if((str[Start] >= 'A')&&(str[Start] <= 'Z'))
            {
                str[Start] = (char)(str[Start] + 32);
            }
            
            else if((str[Start] >= 'a')&&(str[Start] <= 'z'))
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

        char[] CharArr = Arr.ToCharArray();

        Toggle(CharArr);

        string ArrString = new string(CharArr);

        Console.WriteLine(ArrString);
    }
}