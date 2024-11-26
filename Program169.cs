using System;

class Program169
{
    static int iPro = 1;
    static int Pro(int iNo)
    {
        int iDigit = 0;

        if(iNo > 0)
        {
            iDigit = iNo % 10;
            iPro = iPro * iDigit;
            iNo = iNo / 10;
            Pro(iNo);
        }

        return iPro;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the Number : ");
        int iNo = int.Parse(Console.ReadLine());

        int iRet = Pro(iNo);
        Console.WriteLine("The product is : "+iRet);

    }
}