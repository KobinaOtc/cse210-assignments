using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }
    public List<Goal> GetGoals()
    {
        return _goals;
    }
    public void Start() // Starts the goal management app
    {
        Console.Clear();
        bool active = true;
        while (active)
        {
            DisplayPlayerInfo();
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("The Typles of Goals are: ");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                CreateGoal();
            }
            else if (choice == "2")
            {
                Console.WriteLine("The Goals are:");
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                ListGoalNames();
                RecordEvent();
            }
            else if (choice == "6")
            {
                active = false;
            }
            else
            {
                Console.WriteLine("Wrong input! Only '1' '2' '3' '4' '5' & '6' are accepted here!");
            }
        }
    }
    public void DisplayPlayerInfo() // Displays the list of details of the player
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. quit");
        Console.Write("Select a choice from the menu: ");
    }
    public void ListGoalNames() // Shows a list of all goals
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
    }

    public void ListGoalDetails() // Shows the details of the goals.
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }
    public void CreateGoal() // Creates a Goal
    {
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            Console.WriteLine();
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated to this goal? ");
            string points = Console.ReadLine();
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            Console.WriteLine();
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated to this goal? ");
            string points = Console.ReadLine();
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.WriteLine();
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated to this goal? ");
            string points = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string target = Console.ReadLine();
            Console.Write("What is the bonus for accomplishing this? ");
            string bonus = Console.ReadLine();
            _goals.Add(new ChecklistGoal(name, description, points, int.Parse(target), int.Parse(bonus)));
        }
    }
    public void RecordEvent() // Records an event
    {
        Console.Write("Which Goal have you accomplished? ");
        string indexStr = Console.ReadLine();
        int indexInt = int.Parse(indexStr);
        int points = _goals[indexInt - 1].RecordEvent();
        _score += points;
    }
    public void SaveGoals() // Saves Goals
    {
        Console.Write("What is the filename you would like to save your Goals to? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }
    public void LoadGoals() // Loads Goals
    {
        Console.Write("What filename would you want to load your goals from? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        int i = 0;
        foreach (string line in lines)
        {
            if (i != 0)
            {
                string[] parts = line.Split("|");
                string goalType = parts[0];
                if (goalType == "Simple goal")
                {
                    SimpleGoal simp = new SimpleGoal(parts[1], parts[2], parts[3]);
                    if (parts[4] == "True")
                    {
                        simp.SetIsComplete(true);
                    }
                    else
                    {
                        simp.SetIsComplete(false);
                    }
                    _goals.Add(simp);
                }
                else if (goalType == "Eternal Goal")
                {
                    _goals.Add(new EternalGoal(parts[1], parts[2], parts[3]));
                }
                else if (goalType == "Checklist Goal")
                {
                    ChecklistGoal check = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]));
                    check.SetAmountComp(int.Parse(parts[6]));
                    if (parts[7] == "True")
                    {
                        check.SetIsComplete(true);
                    }
                    else
                    {
                        check.SetIsComplete(false);
                    }
                    _goals.Add(check);
                }
            }
            else
            {
                i++;
                _score = int.Parse(line);
            }
        }
        Console.WriteLine("Your Goals have been loaded:");
        ListGoalDetails();
    }
}