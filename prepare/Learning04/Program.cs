using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Axton Hatch", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Ashley Hatch", "Fractions", "6.2", "8-14");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Beau Hatch", "History", "Civil War");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}
    
