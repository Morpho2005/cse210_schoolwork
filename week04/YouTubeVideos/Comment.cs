class Comment{
    string _comment; 
	string _author; 
	public Comment(string author, string comment){ 
		_comment = comment; 
		_author = author; 
    }
    public string GetComment(){
        string comment = $"{_author}: {_comment}";
        return comment;
    }
    public void DisplayComment(){
        Console.WriteLine($"{_author}: {_comment}");
    }
}