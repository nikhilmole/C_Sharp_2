using System;

class Program160
{
    static int i = 1;
    static void Display(int iNum)
    {
        if(iNum < 0)
        {
            iNum = -iNum;
        }

        if(iNum >= i)
        {
            Console.Write("*\t");
            i++;
            Display(iNum);
        }
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        Display(iNo);
    }
}