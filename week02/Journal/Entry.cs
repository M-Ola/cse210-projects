public class Entry
{


    public DateTime Date;
    public string _prompt;
    public string _response;

    public Entry(string prompt, string response)
    {
         Date = DateTime.Now;
        _prompt = prompt;
        _response = response;
    }

    
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}  ");
       
       
    }

    // Format the entry for saving to a text file
    public override string ToString()
    {
        return $"{Date}\n{_prompt}\n{_response}\n---";
    }

   
}
    
    



