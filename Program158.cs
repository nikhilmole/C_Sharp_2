using System;

class Program158
{
    static void Display(int iNum)
    {
        if(iNum > 0)
        {
            Console.Write(iNum+"\t");
            iNum--;
            Display(iNum);
        }
    }
    static void Main(string[] Argcv)
    {
        Console.WriteLine("Enter the Number : ");
        int iNo = int.Parse(Console.ReadLine());

        Display(iNo);
    }
}