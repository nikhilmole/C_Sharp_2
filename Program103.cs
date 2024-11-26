using System;

class Program103
{
    static int Min(int []Arr, int iLength)
    
    {
        int i = 0;
        int Min = Arr[0];

        for(i = 0; i < iLength; i++)
        {
            if(Min > Arr[i])
            {
                Min = Arr[i];
            }
        }
        return Min;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("How many numbers you want to add in array : ");
        int iSize = int.Parse(Console.ReadLine());

        int[] P = new int[iSize];

        int i = 0;

        Console.WriteLine("Enter the numbers : ");
        for(i = 0; i < iSize; i++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }

        int iRet = Min(P, iSize);
        Console.WriteLine("The Minimum number is : "+iRet);
    }
}