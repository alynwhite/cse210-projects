using System;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }

    public string Display()
    {
        return "Not seeming to work";
    }
}