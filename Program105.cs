using System;

class Program105
{
    static void Digits(int []Arr, int iLength)
    {
        int i = 0;
        Console.WriteLine("the three digits numbers is : ");

        for(i = 0; i < iLength; i++)
        {
            if((Arr[i] > 99) &&(Arr[i] < 999))
            {
                Console.WriteLine(Arr[i]);
            }
        }
    }
    static void Main(String[] Agv)
    {
        int i = 0;

        Console.WriteLine("Hwo many numbers you want to aaadd in array : ");
        int iSize = int.Parse(Console.ReadLine());

        int []P = new int[iSize];

        Console.WriteLine("Enter the numbers : ");

        for(i = 0; i < iSize; i++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }

        Digits(P, iSize);

    }
}