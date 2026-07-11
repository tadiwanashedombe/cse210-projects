public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Something I learnt today?",
        "Something that I/m grateful for today?",
        "Wat challenge did i face today and ow did I face it"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        //get random index from prompts list 
        int i = random.Next(_prompts.Count);
        return _prompts[i];
    }
}