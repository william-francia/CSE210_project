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
    Random rand = new Random();

    List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

    if (visibleWords.Count == 0)
        return;

    for (int i = 0; i < numberToHide; i++)
    {
        visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count == 0)
            break;

        int index = rand.Next(visibleWords.Count);
        visibleWords[index].Hide();   
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
    public string GetProgress()
{
    int total = _words.Count;
    int hidden = _words.Count(w => w.IsHidden());

    double percent = (hidden / (double)total) * 100;

    return $"{percent:F0}% hidden";
}

}





