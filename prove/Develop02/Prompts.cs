class Prompts
{
    public List<string> prompts = new List<string>()
    {
        "What was the best part of my day?",
        "What was the most challenging part of my day?",
        "What am I grateful for today?",
        "What is one thing I learned today?",
        "How did I make a positive impact on someone today?",
        "What is a goal I want to achieve tomorrow?",
        "What is something that made me smile today?",
        "What is a skill I want to improve and how can I work on it?",
    };

    // Create a random generator for prompts
    public Random random = new Random();

    // Method to get a random prompt
    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count); //this picks a random index
        return prompts[index]; //this returns the prompt at that index
    }
}