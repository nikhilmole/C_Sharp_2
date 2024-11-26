using System;

class Program153
{
    static void Display(char[] str)
    {
        int End = str.Length;
        int i =  0;

        while(i < End)
        {
            int j = 0;

            while(j < End)
            {
                if(i >= j)
                {
                    Console.Write(str[j]+"\t");
                }
                else
                {
                    Console.Write("\t");
                }
                j++;
            }
            Console.WriteLine();
            i++;
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