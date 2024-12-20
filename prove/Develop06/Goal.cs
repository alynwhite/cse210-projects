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
    public int GetPoints(){
        int p = int.Parse(_points);
        return p;
    }
    public void SetPoints(string points){
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString(){
        return $"{_shortname}|{_description}|{IsComplete()}|{_points}";
    }
    public abstract string GetStringRepresentation();
}