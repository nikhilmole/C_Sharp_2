using System;

class Program104
{
    static int Dif(int []Arr, int iLength)
    {
        int i = 0;
        int iMin = Arr[0];
        int iMax = Arr[0];

        for(i = 0; i < iLength; i++)
        {
            if(iMax < Arr[i])
            {
                iMax = Arr[i];
            }
            else if(iMin > Arr[i])
            {
                iMin = Arr[i];
            }
        }
        return iMax - iMin;
    }
    static void Main(String[] Argv)
    {
        Console.WriteLine("How many numbers you want to add in array : ");
        int iSize = int.Parse(Console.ReadLine());

        int i = 0;
        int[] P = new int[iSize];

        Console.WriteLine("Enter the numbers : ");
        for(i = 0; i < iSize; i++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }

        int iRet = Dif(P, iSize);
        Console.WriteLine("The dif is : "+iRet);
    }
}