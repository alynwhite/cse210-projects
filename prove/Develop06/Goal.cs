using System.ComponentModel;

public abstract class Goal{
    private string _shortname;
    private string _description;
    private string _points;

    public Goal(string shortname, string description, string points){
        _shortname = shortname;
        _description = description;
        _points = points;
    }
    public string GetName(){
        return _shortname;
    }

    public string GetDescription(){
        return _description;
    }

    public string GetPoints(){
        return _points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsSring(){
        return $"{_shortname}({_description})";
    }
    public abstract string GetStringRepresentation();
}