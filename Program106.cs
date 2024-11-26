using System;

class Program106
{
    static void SumofDigi(int []Arr, int iLength)
    {
        int i = 0;
        int iSum = 0;
        int iDigit = 0;
        int iNo = 0;

        Console.WriteLine("The Sum of Digits are : ");

        for(i = 0; i < iLength; i++)
        {
            iNo = Arr[i];
            iSum  = 0;
            while(iNo > 0)
            {
                iDigit = iNo % 10;
                iSum = iSum + iDigit;
                iNo = iNo / 10;
            }
            Console.WriteLine(iSum);
        }
    }
    static void Main(string[] Argv)
    {
        int i = 0;

        Console.WriteLine("How many numbers you want to add in array : ");
        int iSize = int.Parse(Console.ReadLine());

        int[] P = new int[iSize];

        Console.WriteLine("Enter the numbers : ");
        for(i = 0; i < iSize; i++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }

        SumofDigi(P, iSize);
    }
}