using System;

class Program161
{
    static int i = 0;

    static void Display(int iNum)
    {
        if(iNum < 0)
        {
            iNum = -iNum;
        }

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