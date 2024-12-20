public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public int GetBonus(){
        return _bonus;
    }
    public override void RecordEvent()
    {
        if(_amountCompleted + 1 < _target){
            _amountCompleted += 1;
            }
        else{
            _amountCompleted ++;
            
            SetPoints(_bonus.ToString());
        }
    
    }
    public override bool IsComplete()
    {
        if(_amountCompleted >= _target){
            return true;
        }
        else{
            return false;
        }
    }
    public override string GetDetailsString()
    {
        return $"{GetName()}|{GetDescription()}|{IsComplete()}|{GetPoints()}|{_target}|{_amountCompleted}|{_bonus}";
    }

    public override string GetStringRepresentation()
    {
        return "ChecklistGoal";
    }
}