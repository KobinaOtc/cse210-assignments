using System.Dynamic;

public class Scriptures
{
    public Scriptures()
    {
        SetScripture();
    }
    private List<string> _scriptureVerses = new List<string>
    {
        // New Testament (KJV)
        "I can do all things through Christ which strengtheneth me.",
        "For God hath not given us the spirit of fear; but of power, and of love, and of a sound mind.",
        "Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.",
        "And we know that all things work together for good to them that love God, to them who are the called according to his purpose.",
        "Peace I leave with you, my peace I give unto you: not as the world giveth, give I unto you. Let not your heart be troubled, neither let it be afraid.",

        // Old Testament (KJV)
        "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
        "Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee.",
        "The LORD is my shepherd; I shall not want.",
        "For I know the thoughts that I think toward you, saith the LORD, thoughts of peace, and not of evil, to give you an expected end.",
        "To every thing there is a season, and a time to every purpose under the heaven.",

        // Book of Mormon
        "Adam fell that men might be; and men are, that they might have joy.",
        "When ye are in the service of your fellow beings ye are only in the service of your God.",
        "And if men come unto me I will show unto them their weakness.",
        "By small and simple things are great things brought to pass.",
        "Therefore let your light so shine before this people, that they may see your good works and glorify your Father who is in heaven."
    };
    private List<string> _verses = new List<string>()
    {
        // New
        "Philippians 4:13",
        "2 Timothy 1:7",
        "Matthew 5:16",
        "Romans 8:28",
        "John 14:27",
        // Old
        "Proverbs 3:5-6",
        "Isaiah 41:10",
        "Psalm 23:1",
        "Jeremiah 29:11",
        "Ecclesiastes 3:1",
        // Mormon
        "2 Nephi 2:25",
        "Mosiah 2:17 ",
        "Ether 12:27",
        "Alma 37:6",
        "3 Nephi 12:16",
    };

    private string _selectedVerse;
    private string _selectedVerseTxt;

    public void SetScripture()
    {
        Random randomGen = new Random();
        int index = randomGen.Next(0, 14);
        _selectedVerse = _verses[index];
        _selectedVerseTxt = _scriptureVerses[index];
    }
    public string GetVerse()
    {
        return _selectedVerse;
    }
    public string GetScripture()
    {
        return _selectedVerseTxt;
    }
}