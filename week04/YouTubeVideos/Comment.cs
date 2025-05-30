/*
-------------------------------------
|             Comment               |
-------------------------------------
| - _commenterName: string          |
| - _text: string                   |
-------------------------------------
| + Comment(commenterName: string, text: string) |
| + DisplayComment(): void          |
-------------------------------------
*/
class Comment
{
    public string _commenterName;
    public string _text;

    // Consturctor
    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    // Methods
    public void DisplayComment()
    {
        Console.WriteLine($"Name: {_commenterName}");
        Console.WriteLine($"Comment: {_text}");
        Console.WriteLine();
    }
}