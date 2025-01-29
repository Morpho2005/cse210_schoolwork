class Video{
    string _title;
    string _author;
    int _seconds;
    List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int seconds){ 
		_title = title; 
		_author = author; 
		_seconds = seconds; 
	} 
    public void AddComment(string author, string comment){
        _comments.Add(new Comment(author, comment));
    }
    public string GetVideoStats(){
        return $"{_title}, made by {_author}, {_seconds} seconds, {_comments.Count} comments";
    }
}