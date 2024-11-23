public class Scripture{
    private Reference _reference;
  
    private List<Words> _words = new List<Words>();

    private Random _rnd = new Random();

    public Scripture(Reference reference, string text){
        _reference = reference;
        string[] split_str = text.Split(' ');
        foreach(string c in split_str){
            Console.WriteLine(c);
            Words w1 = new Words(c);
            _words.Add(w1);
        }
    }

    public void HideRandomWords(int numberToHide){
        int count_words = 0;
        while(count_words < numberToHide){
            int rnd_index = _rnd.Next(_words.Count);
            if(_words[rnd_index].IsHidden() == false){
                _words[rnd_index].Hide();
                count_words ++;
            }
        }

    }

    public string GetDisplayText(){
        string scrip_text = "";
        for(int i = 0; i < _words.Count; i++){
            scrip_text += " " +_words[i].GetDisplayText();
        }
        return _reference.GetDisplayText() + scrip_text;
    }

    public bool IsCompletelyHidden(){
        int count_hidden = 0;
        for(int i = 0; i<_words.Count; i++){
            if (_words[i].IsHidden() == true){
                count_hidden ++;
            }
        }
        if(count_hidden == _words.Count){
            return true;
        }
        else{
            return false;
        }
    }
}