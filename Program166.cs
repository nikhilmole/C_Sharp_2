using System;

class Program166
{
    static int iSum = 0;
    static int DigiSum(int iNo)
    {
        int iDigit = 0;

        if(iNo > 0)
        {
            iDigit = iNo % 10;
            iSum = iSum + iDigit;
            iNo = iNo / 10;

            DigiSum(iNo);
        }
        return iSum;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        int iRet = DigiSum(iNo);
        Console.WriteLine(iRet);
    }
}