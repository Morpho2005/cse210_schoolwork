public class GoalManager{
    List<Goal> _goals = new List<Goal>();
    int _score;

    public GoalManager(){
        _score = 0;
    }

    public void Start(){
        
    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"number of goals:{_goals.Count}");
        Console.WriteLine($"Current score: {_score}");
    }

    public void ListGoalNames(){
        foreach (Goal g in _goals){
            Console.WriteLine(g._shortName);
        }
    }

    public void ListGoalDetails(){
        foreach (Goal g in _goals){
            Console.WriteLine(g.GetDetailsString());
        }
    }

    public void CreateGoals(){
        Console.Clear();
        Console.WriteLine("What kind of Goal do you wish to make?");
        Console.WriteLine("Type s for Simple");
        Console.WriteLine("Type e for Eternal");
        Console.WriteLine("Type c for Checklist");
        string choice = Console.ReadLine();
        while (choice != "s" || choice != "e" || choice != "c"){
            Console.Clear();
            Console.WriteLine("What kind of Goal do you wish to make?");
            Console.WriteLine("Type s for Simple");
            Console.WriteLine("Type e for Eternal");
            Console.WriteLine("Type c for Checklist");
            choice = Console.ReadLine();
        }
        if (choice == "s"){
            Console.Clear();
            Console.WriteLine("Creating Simpe Task");
            Console.Write("What is the Goals Name? ");
            string name = Console.ReadLine();
            Console.Write("Provide a description of the Goal: ");
            string description = Console.ReadLine();
            Console.Write("How many points is the Goal worth");
            int points = int.Parse(Console.ReadLine());
            SimpleGoal simple = new SimpleGoal(name, description, points);
            _goals.Add(simple);
        } else if(choice == "e"){
            Console.Clear();
            Console.WriteLine("Creating Eternal Task");
            Console.Write("What is the Goals Name? ");
            string name = Console.ReadLine();
            Console.Write("Provide a description of the Goal: ");
            string description = Console.ReadLine();
            Console.Write("How many points is the Goal worth");
            int points = int.Parse(Console.ReadLine());
            EternalGoal eternal = new EternalGoal(name, description, points);
            _goals.Add(eternal);
        } else if(choice == "c"){
            Console.Clear();
            Console.WriteLine("Creating Eternal Task");
            Console.Write("What is the Goals Name? ");
            string name = Console.ReadLine();
            Console.Write("Provide a description of the Goal: ");
            string description = Console.ReadLine();
            Console.Write("How many points is the Goal worth? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times must the Goal be comepleted? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the Bonus for comepleting all the tasks? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklist);
        }
    }

    public void RecordEvent(){
        foreach (Goal g in _goals){
            if (!g.IsComplete()){
                g.RecordEvent();
            }
        }
    }

    public void SaveGoals(){
        Console.Write("What do you want the file name to be? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {   
            foreach (Goal g in _goals){
                outputFile.WriteLine(g.GetStringRepresentation());
            }
            outputFile.WriteLine($"score:{_score}");
            Console.WriteLine("saving to file...");
        }
    }

    public void LoadGoals(){
        
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(fileName);
        List<Goal> oldGoals = new List<Goal>();
        foreach (string line in lines){
            string[] vars = line.Split(',');
            if (vars.Length==4){
                string name = vars[1].Split(':')[2];
                string description = vars[2].Split(':')[2];
                int points = int.Parse(vars[3].Split(':')[2]);
                string comeplete = vars[4].Split(':')[2];
                SimpleGoal goal = new SimpleGoal(name, description, points);
                if (comeplete=="y"){
                    goal._isComplete=true;
                } else {
                    goal._isComplete=false;
                }
                oldGoals.Add(goal);
            } else if (vars.Length==3){
                string name = vars[1].Split(':')[2];
                string description = vars[2].Split(':')[2];
                int points = int.Parse(vars[3].Split(':')[2]);
                EternalGoal goal = new EternalGoal(name, description, points);
                oldGoals.Add(goal);
            } else if (vars.Length==6){
                string name = vars[1].Split(':')[2];
                string description = vars[2].Split(':')[2];
                int points = int.Parse(vars[3].Split(':')[2]);
                int target = int.Parse(vars[4].Split(':')[2]);
                int amountCompleted = int.Parse(vars[5].Split(':')[2]);
                int bonus = int.Parse(vars[6].Split(':')[2]);
                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                goal._amountCompleted=amountCompleted;
                oldGoals.Add(goal);
            } else if (vars.Length==1){
                _score = int.Parse(vars[1].Split(':')[2]);
            }
        }
        _goals = oldGoals;
    }
}