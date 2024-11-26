using System;

class Program156
{
    static int i = 1;
    static void Display(int iNum)
    {
        if(i <= iNum)
        {
            Console.Write("*\t");
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