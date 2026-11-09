using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string part in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            _words.Add(new Word(part));
        }
    }

    // Hides words that are still visible, so every press of Enter makes progress.
    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        int count = Math.Min(numberToHide, visibleWords.Count);
        for (int i = 0; i < count; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    // Reveals one hidden word at random when the user needs a hint.
    public void RevealRandomWord()
    {
        List<Word> hiddenWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hiddenWords.Add(word);
            }
        }

        if (hiddenWords.Count > 0)
        {
            hiddenWords[_random.Next(hiddenWords.Count)].Show();
        }
    }

    public string GetDisplayText()
    {
        List<string> parts = new List<string>();
        foreach (Word word in _words)
        {
            parts.Add(word.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()} {string.Join(" ", parts)}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public int GetHiddenCount()
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }

    public int GetWordCount()
    {
        return _words.Count;
    }
}