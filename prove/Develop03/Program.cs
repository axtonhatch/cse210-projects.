using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorizer!");

        Scripture myScripture = new Scripture("Genesis", "1", "26-27" , "And God said, Let us make man in our image, after our likeness: and let them have dominion over the fish of the sea, and over the fowl of the air, and over the cattle, and over all the earth, and over every creeping thing that creepeth upon the earth. So God created man in his own image, in the image of God created he him; male and female created he them.");
        bool finish = false;
        string answer;
        while (finish == false)

        {Console.WriteLine ("Press the Enter key to continue or type quit to finish");
        answer  = Console.ReadLine();

        myScripture.DisplayRenderedText();
        myScripture.HideWords();
        myScripture.IsCompletelyHidden();

        if (answer == "quit")
        {
            finish = true;
        }
        }
    }
}