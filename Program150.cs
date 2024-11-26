using System;

class Program150
{
    static void Display(char[] str)
    {
        int Start = 0;
        int End = str.Length-1;

        while(str[Start] < str[End])
        {
            int j = 0;
            
            while(str[j] < str[End])
            {
                Console.Write(str[j]+"\t");
                j++;
            }
            Console.WriteLine();
            Start++;
        }
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] CharArr = Arr.ToCharArray();

        Display(CharArr);
    }
}