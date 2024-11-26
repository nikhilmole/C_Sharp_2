using System;

class Program162
{   
    static void Display(int iNum)
    {
        if(iNum < 0)
        {
            iNum = -iNum;
        }

        if(iNum > 0)
        {
            Console.Write(iNum+"\t");
            iNum--;
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