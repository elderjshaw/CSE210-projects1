using System;
using System.Collections.Generic;
using System.IO;


class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }


    public void HideRandWord(int numToHide)
    {
        for (int i = 0; i < numToHide; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }


    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} — {text}";
    }

}