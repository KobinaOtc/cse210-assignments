
public class Resume
{
    public string name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Jobs:");
        foreach (Job j in _jobs)
        {
            j.Display();
        }
    }
}