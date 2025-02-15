public class GoalManager{
    List<Goal> _goals = new List<Goal>();
    int _score;

    public GoalManager(){
        _score = 0;
    }

    public void Start(){
        int choice = 0;
        while (choice != 6){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1){
                CreateGoals();
            } else if (choice == 2){
                ListGoalDetails();
            } else if (choice == 3){
                SaveGoals();
            } else if (choice == 4){
                LoadGoals();
            } else if (choice == 5){
                RecordEvent();
            }
            DisplayPlayerInfo();
            Console.ReadLine();
        }
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
        int count = 1;
        foreach (Goal g in _goals){
            Console.WriteLine($"{count}. {g.GetDetailsString()}");
            count++;
        }
    }

    public void CreateGoals(){
        Console.Clear();
        Console.WriteLine("What kind of Goal do you wish to make?");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        int choice = int.Parse(Console.ReadLine());
        while (choice != 1 & choice != 2 & choice != 3){
            Console.Clear();
            Console.WriteLine("What kind of Goal do you wish to make?");
            Console.WriteLine("1. Simple");
            Console.WriteLine("2. Eternal");
            Console.WriteLine("3. Checklist");
            choice = int.Parse(Console.ReadLine());
        }
        if (choice == 1){
            Console.Clear();
            Console.WriteLine("Creating Simpe Task");
            Console.Write("What is the Goals Name: ");
            string name = Console.ReadLine();
            Console.Write("Provide a description of the Goal: ");
            string description = Console.ReadLine();
            Console.Write("How many points is the Goal worth: ");
            int points = int.Parse(Console.ReadLine());
            SimpleGoal simple = new SimpleGoal(name, description, points);
            _goals.Add(simple);
        } else if(choice == 2){
            Console.Clear();
            Console.WriteLine("Creating Eternal Task");
            Console.Write("What is the Goals Name: ");
            string name = Console.ReadLine();
            Console.Write("Provide a description of the Goal: ");
            string description = Console.ReadLine();
            Console.Write("How many points is the Goal worth: ");
            int points = int.Parse(Console.ReadLine());
            EternalGoal eternal = new EternalGoal(name, description, points);
            _goals.Add(eternal);
        } else if(choice == 3){
            Console.Clear();
            Console.WriteLine("Creating Eternal Task");
            Console.Write("What is the Goals Name: ");
            string name = Console.ReadLine();
            Console.Write("Provide a description of the Goal: ");
            string description = Console.ReadLine();
            Console.Write("How many points is the Goal worth: ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times must the Goal be comepleted: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the Bonus for comepleting all the tasks: ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklist);
        }
    }

    public void RecordEvent(){
        Console.Clear();
        foreach (Goal g in _goals){
            if (!g.IsComplete()){
                g.RecordEvent();
                string[] vars = g.GetStringRepresentation().Split(',');
                if (vars.Length == 6){
                    if (g.IsComplete()){
                        _score += int.Parse(vars[5].Split(':')[1]);
                    }
                    _score += g._points;
                } else {
                    _score += g._points;
                }
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
                string name = vars[0].Split(':')[1];
                string description = vars[1].Split(':')[1];
                int points = int.Parse(vars[2].Split(':')[1]);
                string comeplete = vars[3].Split(':')[1];
                SimpleGoal goal = new SimpleGoal(name, description, points);
                if (comeplete=="y"){
                    goal._isComplete=true;
                } else {
                    goal._isComplete=false;
                }
                oldGoals.Add(goal);
            } else if (vars.Length==3){
                string name = vars[0].Split(':')[1];
                string description = vars[1].Split(':')[1];
                int points = int.Parse(vars[2].Split(':')[1]);
                EternalGoal goal = new EternalGoal(name, description, points);
                oldGoals.Add(goal);
            } else if (vars.Length==6){
                string name = vars[0].Split(':')[1];
                string description = vars[1].Split(':')[1];
                int points = int.Parse(vars[2].Split(':')[1]);
                int target = int.Parse(vars[3].Split(':')[1]);
                int amountCompleted = int.Parse(vars[4].Split(':')[1]);
                int bonus = int.Parse(vars[5].Split(':')[1]);
                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                goal._amountCompleted=amountCompleted;
                oldGoals.Add(goal);
            } else if (vars.Length==1){
                _score = int.Parse(vars[0].Split(':')[1]);
            }
        }
        _goals = oldGoals;
    }
}