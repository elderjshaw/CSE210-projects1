using System;
using System.Collections.Generic;
using System.IO;


class Reference
{
    private string _book;
    private int _chap;
    private int _verse;
    private int _endVerse;
    public Reference(string book, int chapter, int verse, int endVerse = -1)
    {
        _book = book;
        _chap = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }


    public string GetDisplayText()
    {
        if (_endVerse != -1)
        {
            return $"{_book} {_chap}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chap}:{_verse}";
        }
    }
}