class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private static Random _random = new Random();

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetReferenceString());
        foreach (Word word in _words)
        {
            word.Display();
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int wordsHidden = 0;

        int visibleWordCount = _words.Count(word => word.isRevealed()); // Tracks the number of words left 
        numberToHide = Math.Min(numberToHide, visibleWordCount); // changes value of NumberToHide if it is less then 3

        while (wordsHidden < numberToHide)
        {
            int index = _random.Next(_words.Count); 
            if (_words[index].isRevealed())
            {
                _words[index].Hide(); // hides the random word in the sentence
                wordsHidden++; // adds to the count of words hidden
            }
        }
    }
    
    public int VisibleWordCount() //I will use this method if there are less then 3 words left to hide
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (word.isRevealed())
            {
                count++; // Counts the number of visible words
            }
        }
        return count; // Returns the count of visible words
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (word.isRevealed()) // Checks if any word is still visible on the terminal 
            {
                return false;
            }
        }
        return true; // All words are hidden and loop ends 
    }
}