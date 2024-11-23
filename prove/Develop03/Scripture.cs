public class Scripture{
    private Reference _reference;
  
    private List<Words> _words = new List<Words>();

    public Scripture(Reference reference, string text){
        _reference = reference;
        foreach(string w in text.Split(' ')){
            
        }

    }
}