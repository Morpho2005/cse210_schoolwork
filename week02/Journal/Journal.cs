public class Journal {
    List<Entry> _entries = new List<Entry>();

    

    public void DisplayAll(){
        for (int i = 0; i < _entries.Count(); i++)
        {
            _entries[i].Display();
        }
    }

    public void AddEntry(){
        Entry _entry = new Entry();
        _entry.FillEntry();
        _entries.Add(_entry);
    }

    public void SaveToFile(){
        Console.Write("What do you want the file name to be? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {   
            foreach (Entry e in _entries){
                outputFile.WriteLine(e._entryText);
            }
            Console.WriteLine("saving to file...");
        }
    }
    public void LoadFromFile(){
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        List<Entry> _oldEntries = new List<Entry>();
        foreach (string line in lines){
            Entry _entry = new Entry();
            _entry._entryText = line;
            _oldEntries.Add(_entry);
        }
        _entries = _oldEntries;
    }
}