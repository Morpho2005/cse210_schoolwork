public class Word{
    string _word;
    bool _isHidden;
    public Word(){}
    public Word(string word){
        _word = word;
    }

    public void Hide(){
        _isHidden = true;
    }

    public void Show(){
        _isHidden = false;
    }

    public bool IsHidden(){
        return _isHidden;
    }

    public void Display(){
        Console.WriteLine(_word);
    }

    public void GetWord(){
        Console.Write("Word input: ");
        _word = Console.ReadLine();
    }

    public string GetDisplayText(){
        if (_isHidden == false){
            return _word;
        } else {
            int lenght = _word.Length;
            string blank = "";
            for (int i = 0; i < lenght; i++){
                blank = blank+"_";
            }
            return blank;
        }
    }
}