using System;

class Progeam145
{
    static void ToggleAndRev(char[] str)
    {
        int Start = 0;
        int End = str.Length-1;
        char temp = '\0';

        while(Start < End)
        {
            if(str[Start] >= 'A' && str[Start] <= 'Z')
            {
                str[Start] = (char)(str[Start] + 32);
            }

            else if(str[Start] >= 'a' && str[Start] <= 'z')
            {
                str[Start] = (char)(str[Start] - 32);
            }

            if(str[End] >= 'A' && str[End] <= 'Z')
            {
                str[End] = (char)(str[End] + 32);
            }

            else if(str[End] >= 'a' && str[End] <= 'z')
            {
                str[End] = (char)(str[End] - 32);
            }

            temp = str[End];
            str[End] = str[Start];
            str[Start] = temp;

            Start++;
            End--;
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] CharArr = Arr.ToCharArray();

        ToggleAndRev(CharArr);

        Console.WriteLine(CharArr);
    }
}