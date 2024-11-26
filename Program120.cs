using System;

class Program120
{
    static bool ChkVowel(string str)
    {
        int Length = str.Length;
        int Index = 0;
        bool bFlag = false;

        while(Index < Length)
        {
            if((str[Index] == 'A')||(str[Index] == 'E')||(str[Index] == 'I')||(str[Index] == 'O')||(str[Index] == 'U')||
            (str[Index] == 'a')||(str[Index] == 'e')||(str[Index] == 'i')||(str[Index] == 'o')||(str[Index] == 'u'))
            {
                bFlag = true;
            }
            Index++;
        }
        return bFlag;
    }
    static void Main(string[] Argv)
    {
        Console.WriteLine("Enter the String : ");
        string Arr = Console.ReadLine();

        bool bRet = false;

        bRet = ChkVowel(Arr);

        if(bRet == true)
        {
            Console.WriteLine("Vowel Present");
        }
        else
        {
            Console.WriteLine("Vowel not present");
        }
    }
}