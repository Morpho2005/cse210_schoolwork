public class GoalManager{
    List<Goal> _goals = new List<Goal>();
    int _score;

    public GoalManager(){
        _score = 0;
    }

    public void Start(){

    }

    public void DisplayPlayerInfo(){

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

    }

    public void LoadGoals(){

    }
}