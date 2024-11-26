using System;

class Program119
{
    static int Dif(string str)
    {
        int iCountCap = 0;
        int iCountSmall = 0;
        int Index = 0;
        int Length = str.Length;

        while(Index < Length)
        {
            if((str[Index] >= 'A')&&(str[Index] <= 'Z'))
            {
                iCountCap++;
            }
            else
            {
                iCountSmall++;
            }
            Index++;
        }
        return iCountCap - iCountSmall;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        int iRet = Dif(Arr);

        Console.WriteLine("The dif is : "+iRet);
    }
}