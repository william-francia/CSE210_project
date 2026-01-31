using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        // Dividir el texto en palabras
        string[] splitWords = text.Split(" ");

        _words = new List<Word>();

        foreach (String w in splitWords)
        {
            _words.Add (new Word (w));
        }
    }
    
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (numberToHide > visibleWords.Count)
        {
            numberToHide = visibleWords.Count;
        }

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(visibleWords.Count);

            visibleWords[index].Hide();

            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();

        List<string> wordsToDisplay = new List<string>();

        foreach (Word w in _words)
        {
            wordsToDisplay.Add(w.GetDisplayText());
        }

        string scriptureText = string.Join(" ", wordsToDisplay);

        return $"{referenceText} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false; 
            }
        }

        return true; 
    }
}





