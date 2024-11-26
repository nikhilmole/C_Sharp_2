using System;

class Program164
{
    static int i = 0;

    static void Display(int iNum, char ch)
    {
        if(iNum < 0)
        {
            iNum = - iNum;
        }

        if((i <= iNum)&&(ch != ' '))
        {
            Console.Write(ch+"\t");

            ch++;
            i++;
            Display(iNum, ch);

        }   
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the Character : ");
        char ch = char.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        Display(iNo, ch);
    }
}