using System.Diagnostics.Contracts;

public class Video{
    public string _title;
    public string _author;
    public int _videoLength;
    public List<Comment> _comments = new List<Comment>();

    public void DisplayVideo(){
        Console.WriteLine($"- - - - - - - - - \nTitle: {_title} \nAuthor: {_author} \nLength: {_videoLength} secs \nComments({NumberOfComments()})");
        LoopComments();
        Console.WriteLine("\n");
    }
    public void LoopComments(){
        for(int i = 0; i < _comments.Count; i++){
            _comments[i].DisplayComment();
        }
    }
    public void AddComment(Comment comment1){
        _comments.Add(comment1);
    }
    public int NumberOfComments(){
        return _comments.Count;
    }
}