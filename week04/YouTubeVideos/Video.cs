/*
-------------------------------------
|             Video                 |
-------------------------------------
| - _title: string                  |
| - _author: string                 |
| - _lengthInSeconds: int           |
| - _comments: List<Comment>        |
-------------------------------------
| + Video(title: string, author: string, lengthInSeconds: int) |
| + AddComment(comment: Comment): void |
| + GetNumberOfComments(): int      |
| + DisplayVideoDetails(): void     |
-------------------------------------
*/
class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public List<Comment> _comments;

    // Constructor
    Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    // Methods
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        int count = 0;
        foreach(Comment com in _comments)
        {
            count++;
        }
        return count;
    }
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Authour: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds}");
        Console.WriteLine($"Comments:");
        foreach (Comment com in _comments)
        {
            com.DisplayComment();
        }
    }
}