using System.IO;
public class Entries
{
    public string _fileName;
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Response: {entry._response}");
            Console.WriteLine("");
        }
    }
    public void Load()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
            Console.WriteLine("");
        }
    }

    public void Save()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date}~|~Prompt: {entry._prompt}~|~Response: {entry._response}");
            }
        }
    }
}