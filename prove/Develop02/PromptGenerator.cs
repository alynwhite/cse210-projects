using System;

public class PromptGenerator{
    public List<string> _prompts = new List<string>();


    public string GetRandomPrompt(){
        _prompts.Add("What made me smile first today? ");
        _prompts.Add("What made me laugh today? ");
        _prompts.Add("How many times did I go to the fridge today? ");
        _prompts.Add("What was the subject of a picture I saw today? ");
        _prompts.Add("What was the strongest emotion I felt today? ");
        _prompts.Add("What was one animal I saw today? ");
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day? ");
        _prompts.Add("Hw did I see the hand of the Lord today? ");
        _prompts.Add("If I had one thing I could do over today, what would it be? ");

        Random randomGenerator = new Random();
        int rndmIndex = randomGenerator.Next(1, _prompts.Count);

        string random_prompt = _prompts[rndmIndex];

        return random_prompt;
    }
}