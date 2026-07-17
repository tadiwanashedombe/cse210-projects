public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');
        foreach(string word in words)
        {
            _words.Add(new Word(word));
        }

    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int countHidden = 0;

        while(countHidden < numberToHide && !IsCompletelyHidden())
        {
            // track index of hidden
            int i = random.Next(_words.Count);
            
            if (!_words[i].IsHidden())
            {
                _words[i].Hide();
                countHidden++;
            }
        }

    }
    public string GetDisplayText()
    {
        string showtext = $"{_reference.GetDisplayText()}\n";
        foreach(Word word in _words)
        {
            showtext += $"{word.GetDisplayText()} ";
        }

        return showtext;
    }
    public bool IsCompletelyHidden()
    {
        
        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}