using System;


class Program146
{
    static bool Plindrome(char[] str)
    {
        int Start = 0;
        int End = str.Length - 1;

        while(Start < End)
        {
            if(str[Start] >= 'A' && str[Start] <= 'Z')
            {
                str[Start] = (char)(str[Start] + 32);
            }
            if(str[End] >= 'A' && str[End] <= 'Z')
            {
                str[Start] = (char)(str[Start] + 32);
            }

            while(str[Start] != str[End])
            {
                return false;
            }

            Start++;
            End--;
        }

        return true;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        bool bRet = false;

        char[] CharArr = Arr.ToCharArray();

        bRet = Plindrome(CharArr);

        if(bRet == true)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine(" NOn Palindrome");
        }
    }
}
