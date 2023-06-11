using System;

class Program
{
    static void Main(string[] args)
    {
       
        BreathingActivity Breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectingActivity Reflect = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
        ListingActivity List = new ListingActivity("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        int opcion = 0;
        while (opcion !=4)
        {
                Console.WriteLine("Select a choice from the menu below:\n"+
                "\n1.Breathing activity"+
                "\n2.Reflecting activity"+
                "\n3.Listing activity"+
                "\n4.Quit");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion){

                            case 1:
                            Breathing.InicialMessage();
                            Breathing.BreathComplete();
                            Breathing.LastMessage();
                                break;
                            case 2:
                            Reflect.InicialMessage();
                            Reflect.ReflectionComplete();
                                break;
                            case 3:
                            List.InicialMessage();
                            List.ListingComplete();
                                break;
                            case 4:
                                Console.WriteLine("Goodbye");
                                break;
                            default:
                                Console.Write("Please enter a valid option:\n");
                                break;
                    }
        }
    }
}