using System;

class Program101
{
    static int Product(int []Arr, int iLength)
    {
        int i = 0;
        int iPro = 1;

        for(i = 0; i < iLength; i++)
        {
            if(Arr[i] % 2 != 0)
            {
                iPro = iPro * Arr[i];
            }
        }
        return iPro;
    }
    static void Main(string[] Arhv)
    {
        Console.WriteLine("How many number you want to add in array : ");
        int iSize = int.Parse(Console.ReadLine());

        int i = 0;
        int[] P = new int[iSize];

        Console.WriteLine("Enter numbers : ");
        for(i = 0; i < iSize; i++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }

        int iRet = Product(P, iSize);

        Console.WriteLine("The product is : "+iRet);

    }
}