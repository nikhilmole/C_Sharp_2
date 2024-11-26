using System;

class Program102
{
    static int Max(int []Arr, int iLength)
    {
        int i = 0;
        int iMax = Arr[0];

        for(i = 0; i < iLength; i++)
        {
            if(iMax < Arr[i])
            {
                iMax = Arr[i];
            }
        }
        return iMax;
    }
    static void Main(String[] Argv)
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

        int iRet = Max(P, iSize);
        Console.WriteLine("The Max number is : {0}",iRet);
    }
}