using System;

public class Questions
{
    public void Display()
    {
        List<string> mylist = new List<string>(new string[] 
        {"Who was the person you were most excited to see today?",
        "What has your favorite thing you ate today?",
        "How was your day on a scale of 1 - 10? And Why?",
        "What exersise did you do today?",
        "Did you pray today?"});

        Random  Rndm = new Random();

        int someRandomQuestion = Rndm.Next(0, mylist.Count());

        Console.WriteLine(mylist.ElementAt(someRandomQuestion));
    }
}