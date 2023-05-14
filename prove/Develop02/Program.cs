using System;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        Console.WriteLine("Welcome to the most EPIC journal entry device every created!");
        while (number != 5)
        {
            Console.WriteLine("Please select one of the options");

            Console.WriteLine("1 Write");
            Console.WriteLine("2 Display");
            Console.WriteLine("3 Load");
            Console.WriteLine("4 Save");
            Console.WriteLine("5 Quit");

            Console.Write("What would you like to do?");

            string userEntry = Console.ReadLine();
            number = int.Parse(userEntry);

            if (number == 1)
            {
                Entry entryOne = new Entry();
                entryOne.Display1();

                Entry entryTwo = new Entry();
                entryTwo._ask = Console.ReadLine();

                string file = "text.txt";
                string txt = $"Date:{entryTwo._date} Ask:{entryTwo._ask}";
                File.AppendAllLines(file, new string[] { txt });
            }

            else if (number == 2)
            {
                TextRead dis1 = new TextRead();
                dis1.Display2();
                Console.WriteLine();
            }

            else if (number == 5)
            {
                number = 5;
            }

        }
    }
}