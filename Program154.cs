using System;

class Program154
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
                if((str[j] >= 'a')&&(str[j] <= 'z'))
                {
                    str[j] = (char)(str[j] - 32);
                }
                Console.Write(str[j]+"\t");
                j++;
            }
            i++;
            Console.WriteLine();
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        char[] CharArr = Arr.ToCharArray();

        Display(CharArr);        
    }
}