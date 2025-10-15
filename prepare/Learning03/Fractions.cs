using Microsoft.VisualBasic;

class Fractions
{
    private int _top;
    private int _bottom;
    public int GetTop() {return _top;}

    public int SetTop(int top)
    {
        Console.WriteLine("Enter a number: ");
        _top = int.Parse(Console.ReadLine());
        return _top;
    }

    public int GetBottom() {return _bottom;}

    public int SetBottom(int bottom)
    {
        Console.WriteLine("Enter a number: ");
        _bottom = int.Parse(Console.ReadLine());
        return _bottom;
    }

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }
    
    public Fractions(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString() { return $"{_top}/{_bottom}"; }
    
    public double GetDecimalValue() { return (double)_top / _bottom; }
}