
public class Entry
{
    public string _date;
    public string _response;
    public string _prompt;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}~|~Prompt: {_prompt}~|~Response: {_response}");
    }
}