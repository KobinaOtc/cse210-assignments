public class Scripture
{
    Scriptures newScript = new Scriptures();
    Hide hide = new Hide();

    private List<string> _editedVerse = new List<string>();
    private int _displayCount = 0;

    public void SetEdit()
    {
        string scripture = newScript.GetScripture();
        _editedVerse = scripture.Split(" ").ToList();
    }

    public List<string> GetEditScript()
    {
        return _editedVerse;
    }

    public void Display()
    {
        if (_displayCount == 0)
        {
            Console.Clear();
            Console.WriteLine($"{newScript.GetVerse()} - {newScript.GetScripture()}");
            hide.MakeWords(_editedVerse);
            _displayCount++;
        }
        else if (_displayCount == 3)
        {
            Console.Clear();
            hide.HideWords(_displayCount);
            Console.WriteLine($"{newScript.GetVerse()} - {hide.StrHidden(_editedVerse)}");
            _displayCount++;
        }
        else
        {
            Console.Clear();
            hide.HideWords(_displayCount);
            Console.WriteLine($"{newScript.GetVerse()} - {hide.StrHidden(_editedVerse)}");
            _displayCount++;
        }
    }
}