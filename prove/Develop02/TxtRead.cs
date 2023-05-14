using System;

public class TextRead
{
    public void Display2()
    {
        string line;

            StreamReader sr = new StreamReader("text.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
    }
}
