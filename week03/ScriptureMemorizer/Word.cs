public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    // When hidden, each letter becomes an underscore, but punctuation
    // such as commas and periods stays visible as a memory clue.
    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }

        string result = "";
        foreach (char c in _text)
        {
            result += char.IsLetter(c) ? '_' : c;
        }
        return result;
    }
}