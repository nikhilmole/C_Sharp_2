using System;

class Program157
{
    static int i = 1;

    static void Display(int iNum)
    {
        if(i <= iNum)
        {
            Console.Write(i+"\t");
            i++;
            Display(iNum);
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the Number : ");
        int iNo = int.Parse(Console.ReadLine());

        Display(iNo);
    }
}