using System;

class Program133
{
    static void StrCpy(char[] str, char[] dest, int iCnt)
    {
        int Start = 0;
        int End = str.Length;

        while((Start < End)&&(iCnt > 0))
        {
            dest[Start] = str[Start];

            Start++;
            iCnt--;
        }
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the string : ");
        string Arr = Console.ReadLine();

        char[] Brr = new char[Arr.Length];

        char[] CharArr = Arr.ToCharArray();

        Console.WriteLine("Enter the number : ");
        int iNo = int.Parse(Console.ReadLine());

        StrCpy(CharArr,Brr,iNo);

        string Updated = new string(Brr);
        Console.WriteLine("Updated string is : "+Updated);
    }
}