public class Words{
    private string _word;
    private bool _isHidden;
    public Words(string text){
        _word = text;
        _isHidden = false;
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

    public string GetDisplayText(){
        if (IsHidden() == true){
            return "_____";
        }
        else{
            return _word;
        }
    }
}