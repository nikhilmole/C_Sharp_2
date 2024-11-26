using System;

class Program1565
{
    static void Display(char[] str)
    {
        int i = 0;
        int End = str.Length;

        while(i < End)
        {
            int j = 0;
            while(j < End)
            {
                if(str[j] >= 'A' && str[j] <= 'Z')
                {
                    str[j] = (char)(str[j] + 32);
                }
                Console.Write(str[j]+"\t");
                j++;
            }
            Console.WriteLine();
            i++;
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String  : ");
        String Arr = Console.ReadLine();

        char[] CharArr = Arr.ToCharArray();

        Display(CharArr);
    }
}