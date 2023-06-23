public class CGoal : Goal
{
    protected int _extrapoints;
     protected int _bonus;
     protected int _done;
    public CGoal()
    {
    }

     public override void GetGoal()
    {
         Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description of your goal?");
        _description = Console.ReadLine();
        Console.WriteLine("How many points do you want to be associated with this goal?");
        _points = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times do you want to complete this goal for a bonus?");
        _bonus = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for acomplishing it that many times?");
        _extrapoints = int.Parse(Console.ReadLine());
    }

    public override void PrintGoal()
    {
          {
           if (_check == false)
        {
            Console.Write("[]");
        }
        else
        {
            Console.Write("[x]");
        }
        Console.WriteLine($" {_check} {_name} ({_description}) --- Currently completed: {_done}/{_bonus} ");
         }
    }

    public override string SaveFile()
    {
        return $" Checklist Goal - {_name} - {_description} - {_points} - {_extrapoints} - {_bonus}";
    }

    public override void RecordEvent()
    {
         _answer = int.Parse(Console.ReadLine());
        if (_answer == 3)
        {   
            _check = true;
            _totalPoints =+ _points+_checklistPoints +_eternalPoints;
            Console.WriteLine($"Congratulations you've earned {_points} points!");
        }
    }
}