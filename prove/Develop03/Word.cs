class Word
{
    private string _word;
    private bool _isRevealed;

    public Word(string word) // Constructor
    {
        _word = word;
        _isRevealed = true;
    }

    public void Display()
    {
        if (_isRevealed) // Console.Write allows for code to be written on more then one line
        {
            Console.Write(" " + _word);
        }
        else
        {
            Console.Write("______");
        }
    }

    public void Hide() // Setter 
    {
        _isRevealed = false;
    }

    public bool isRevealed()
    { return _isRevealed; }
}