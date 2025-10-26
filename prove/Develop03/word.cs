using System;
using System.Collections.Generic;
using System.IO;


class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }


    public void Hide()  // Method to hide the word
    {
        _isHidden = true;
    }

    public bool IsHidden()  // Method to check if the word is hidden
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
        
    }
    
}