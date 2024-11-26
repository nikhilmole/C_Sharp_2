using System;

class Program111
{
    static void ExamSchedule(char ch)
    {
        switch(ch)
        {
            case 'A':
                Console.WriteLine("Exam of division A at 7 AM");
                break;
        
            case 'B':
                Console.WriteLine("Exam of division B at 8 AM");
                break;

            case 'C':
                Console.WriteLine("Exam of division C at 9 AM");
                break;

            case 'D':
                Console.WriteLine("Exam of division D at 10 AM");
                break;
        
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }
    static void Main(String[] Argv)
    {   
        Console.WriteLine("Enter the Divivsion :");
        char ch = char.Parse(Console.ReadLine());

        ExamSchedule(ch);
    }
}