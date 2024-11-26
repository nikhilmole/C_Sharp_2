using System;


class Program144
{
    static bool StrCmpX(char[] str, char[] dest, int iNo)
    {
        int Start = 0;

        while((Start < str.Length) && (Start < dest.Length) && (iNo > 0))
        {
            if(str[Start] != dest[Start])
            {
                return false;
            }

            Start ++;
            iNo --;
        }

        if(iNo == 0) 
        {
            return true;
        }

        else
        {
            return false;
        }
    }
    static void Main(string[] Argv)
    {
        bool bRet = false;
        Console.WriteLine("Enter the First String : ");
        char[] Arr = Console.ReadLine().ToCharArray();

        Console.WriteLine("Enter the Second String : ");
        char[] Brr = Console.ReadLine().ToCharArray();

        Console.WriteLine("Enter the numbwer : ");
        int iNo = int.Parse(Console.ReadLine());

        bRet = StrCmpX(Arr, Brr, iNo);
        if(bRet == true)
        {   
            Console.WriteLine("The String are same");
        }   
        else
        {
            Console.WriteLine("The String Are not same");
        }
    }
}