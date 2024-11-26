using System;

class Program100
{
    static void Range(int []Arr, int iLength, int iStart, int iEnd)
    {
        int i = 0;

        if(iStart > iEnd)
        {
            Console.WriteLine("Starting range is greater than ending range");
            return;
        }
        for(i = 0; i < iLength; i++)
        {
            if((Arr[i] > iStart)&&(Arr[i] < iEnd))
            {
                Console.WriteLine(Arr[i]+"\t");
            }
        }
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

        Console.WriteLine("Enter the stating range");
        int iNo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the ending range");
        int iNo2 = int.Parse(Console.ReadLine());

        Range(P, iSize, iNo1, iNo2);
    }
}