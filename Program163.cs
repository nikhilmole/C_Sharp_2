using System;

class Program163
{
    static int i = 1;

    static void Display(int iNum, char ch)
    {
        if(iNum < 0)
        {
            iNum = -iNum;
        }

        if((i <= iNum)&&(ch != '\0'))
        {
            Console.Write(ch+"\t");
            ch++;
            i++;
            Display(iNum, ch);
        }
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("Enter the Character : ");
        char ch = char.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Number : ");
        int iNo = int.Parse(Console.ReadLine());

        Display(iNo, ch);
    }
}