public class Reference{
    string _reference;
    public Reference(){}
    public Reference(string book, int chapter, int verse){
        _reference = $"{book} {chapter}:{verse}";
    }
    
    public Reference(string book, int chapter, int startVerse, int endVerse){
        _reference = $"{book} {chapter}:{startVerse}-{endVerse}";
    }
    public void SetReference(string book, int chapter, int verse){
        _reference = $"{book} {chapter}:{verse}";
    }
    public void SetReference(string book, int chapter, int startVerse, int endVerse){
        _reference = $"{book} {chapter}:{startVerse}-{endVerse}";
    }
    public string GetReference(){
        return _reference;
    }
}