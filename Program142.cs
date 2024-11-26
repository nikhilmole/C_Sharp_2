using System;

class Program142
{
    static void StrCnt(char[] str, char[] dest, int iNo)
    {
        int Start = 0;
        int End = Math.Min(dest.Length, iNo);  // Adjust End to avoid index out of bounds.

        // Use a valid index for the destination array
        int strIndex = 0;

        while (Start < End)
        {
            str[strIndex] = dest[Start];
            Start++;
            strIndex++;
        }
    }

    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the First String: ");
        string Arr = Console.ReadLine();

        Console.WriteLine("Enter the Second String: ");
        string Brr = Console.ReadLine();

        char[] CharArr = new char[Arr.Length];
        char[] CharBrr = Brr.ToCharArray();

        Console.WriteLine("Enter the Number of Characters to Copy: ");
        int iNo = int.Parse(Console.ReadLine());

        StrCnt(CharArr, CharBrr, iNo);

        Console.WriteLine("Resulting String: " + new string(CharArr));
    }
}
