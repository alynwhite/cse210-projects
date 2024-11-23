public class Reference{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText(){
        
        string chapter_str = _chapter.ToString();
        string verse_str = _verse.ToString();
        string scrip_reference = _book + " " + chapter_str + ":" + verse_str;
        if (_endVerse != 0){
            string endVerse_str = _endVerse.ToString();
            return scrip_reference += "-" + endVerse_str;
        }
        else{
            return scrip_reference;
        }
    }
}