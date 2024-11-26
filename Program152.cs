using System;

class Program152
{
    static void Display(char[] str)
    {
        int End = str.Length;
        int i = 0;
        int j = 0;

        for(i = 0; i < End; i++)
        {
            for(j = 0; j < End; j++)
            {
                if(j < End - i)
                {
                    Console.Write(str[j]+"\t");
                }        
                else
                {
                    Console.Write("\t");
                }
            }
            Console.WriteLine();
        }

    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Entter the String : ");
        string Arr = Console.ReadLine();

        char[] CharArr = Arr.ToCharArray();

        Display(CharArr);
    }
}