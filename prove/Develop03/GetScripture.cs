class Scripture
{
    private Reference _reference;
    private List<Word> _words;

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
        Random random = new Random();
        int wordsHidden = 0;

        while (wordsHidden < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (_words[index].isRevealed())
            {
                _words[index].Hide(); // Hides the words, but at a random interval 
                wordsHidden++;
            }
        }
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