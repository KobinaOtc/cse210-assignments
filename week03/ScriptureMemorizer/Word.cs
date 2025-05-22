public class Word
{
    private string _word;
    public Word()
    {
        _word = "";
    }
    public Word(string word)
    {
        SetWord(word);
    }

    public string GetWord()
    {
        return _word;
    }

    public void SetWord(string word)
    {
        _word = word;
    }
}