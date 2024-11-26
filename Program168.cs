using System;

class Program168
{
    static int i = 1;
    static int ifacto = 1;

    static int Facto(int iNo)
    {
        if(i <= iNo)
        {
            ifacto = ifacto * i;
            i++;
            Facto(iNo);
        }

        return ifacto;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the Number : ");
        int iValue = int.Parse(Console.ReadLine());

        int iRet = Facto(iValue);
        Console.WriteLine("The factorial are : "+iRet);
    }
}