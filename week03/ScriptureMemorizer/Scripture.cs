public class Scripture{
    List<Word> _words = new List<Word>();
    Reference _reference = new Reference();
    public Scripture(Reference reference, string scripture){
        _reference = reference;
        string[] words = scripture.Split(" ");
        foreach (string word in words){
            Word _word = new Word(word);
            _words.Add(_word);
        }
    }

    public bool IsAllHidden(){
        bool isAllHidden = true;
        foreach (Word word in _words){
            if (!word.IsHidden()){
                isAllHidden = false;
            }
        }
        return isAllHidden;
    }

    public void HideRandomWords(int numberToHide){
        int count = 0;
        foreach (Word word in _words){
            if (!word.IsHidden()){
                count++;
            }
        }
        if (count<numberToHide){
            numberToHide = count;
        }
        for (int i = 0; i < numberToHide; i++){
            Random random = new Random();
            int randnum = random.Next(0,_words.Count());
            if (_words[randnum].IsHidden()){
                i=i-1;
            } else {
                _words[randnum].Hide();
            }
        }
    }

    public string GetDisplayText(){
        string scripture = $"{_reference.GetReference()} ";
        foreach (Word word in _words){
            scripture = $"{scripture} {word.GetDisplayText()}";
        }
        return scripture;
    }
}