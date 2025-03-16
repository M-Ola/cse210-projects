public class PromptGenerator
{

    public List<string> _prompts =
        [
            "What made you smile today?",
            "Describe a challenge you overcame.",
            "What are you grateful for right now?",
            "Write about a memorable childhood experience.",
            "If you could travel anywhere, where would you go?",
            "What does success mean to you?",
            "Describe someone who inspires you.",
            "What's a habit you want to improve?",
            "What lessons did you learn this week?",
             "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
             "What was the strongest emotion I felt today?",
             "If I had one thing I could do over today, what would it be?",
                "What made you smile today?",
                "Describe a challenge you overcame recently.",
                "What are you grateful for right now?",
                "If you could relive any day, which one would it be and why?",
                "What's a dream or goal you are working toward?",
                "What is something new you learned this week?",
                "How do you define success?",
                "What is one thing you would tell your younger self?",
                "What does happiness mean to you?",
                "Describe a person who positively impacted your life.",
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"


        ];

    public Random random;

    public PromptGenerator()
    {

        random = new();
    }


    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }



}



