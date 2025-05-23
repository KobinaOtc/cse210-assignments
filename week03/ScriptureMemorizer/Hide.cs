using System.Diagnostics.Metrics;

public class Hide
{
    private List<Word> _wordsToEdit = new List<Word>();
    private List<int> _editedIndexes = new List<int>();
    private int _numWordToHide = 0;
    Random randomGen = new Random();
    
    public void MakeWords(List<string> verse)
    {
        foreach (string i in verse)
        {
            Word word = new Word();
            word.SetWord(i);
            _wordsToEdit.Add(word);
        }
    }

    private int IndexGen()
    {
        int index = randomGen.Next(0, _wordsToEdit.Count - 1);
        int counter = 0;

        while (_editedIndexes.Contains(index) && counter < 100)
        {
            index = randomGen.Next(0, _wordsToEdit.Count - 1);
            counter++;
        }
        return index;
    }

    public void HideWords(int counter)
    {
        int length = _wordsToEdit.Count;
        _numWordToHide = randomGen.Next(3, 6);

        if (counter < 6)
        {
            for (int i = 0; i < _numWordToHide; i++)
            {
                int index = IndexGen();
                Word chosenWord = _wordsToEdit[index];
                string word = chosenWord.GetWord();
                char[] letters = word.ToCharArray();
                List<string> blkList = new List<string>();
                string blanks = "";
                foreach (char let in letters)
                {
                    blkList.Add("_");
                }
                blanks = string.Join("", blkList);
                chosenWord.SetWord(blanks);
                _editedIndexes.Add(index);
            }
        }
        else
        {
            for (int i = 0; i < _wordsToEdit.Count; i++)
            {
                string word = _wordsToEdit[i].GetWord();
                char[] letters = word.ToCharArray();
                List<string> blkList = new List<string>();
                string blanks = "";
                foreach (char let in letters)
                {
                    blkList.Add("_");
                }
                blanks = string.Join("", blkList);
                _wordsToEdit[i].SetWord(blanks);
            }
        }
    }

    public string StrHidden(List<string> editedScr)
    {
        List<string> script = new List<string>();
        string scripture;
        foreach (Word wrd in _wordsToEdit)
        {
            script.Add(wrd.GetWord());
        }
        editedScr = script;
        scripture = string.Join(" ", script);
        return scripture;
    }
}