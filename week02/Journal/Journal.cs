using System;

public class Journal {
    public List<Entry> _entries = new List<Entry>();

    

    public void DisplayAll(){
        for (int i = 0; i < _entries.Count(); i++)
        {
            _entries[i].Display();
        }
    }
}