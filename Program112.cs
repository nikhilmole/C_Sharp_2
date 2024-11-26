using System;

class Program112
{
    static void ASCII()
    {
        int iNum = 0;
        for(iNum = 0; iNum <= 255; iNum++)
        {
            Console.WriteLine(iNum+"="+(char)iNum);
        }
    }   
    static void Main(String[] Argv)
    {
        ASCII();
    }
}