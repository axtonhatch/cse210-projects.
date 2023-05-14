using System;

public class Entry
{
    public string _date = DateTime.UtcNow.ToString("MM/dd/yyyy");

    public string _ask;

    public void Display1()
    {
        Questions ques1 = new Questions();
        ques1.Display();
    }
}