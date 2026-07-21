public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }

    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int countHidden = 0;

        while (countHidden < numberToHide && !IsCompletelyHidden())
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
    public static Scripture LoadFromFile()
    {
        string[] lines = File.ReadAllLines("scriptures.txt");

        List<string> scriptLines = new List<string>();

        foreach (string line in lines)
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                scriptLines.Add(line);
            }
        }
        // random line
        Random random = new Random();
        int i = random.Next(scriptLines.Count);
        string randomLine = scriptLines[i];

        string[] parts = randomLine.Split("|");
        if (parts.Length == 4)
        {
            string book = parts[0].Trim();
            int chapter = int.Parse(parts[1].Trim());
            int verse = int.Parse(parts[2].Trim());
            string scripturetxt = parts[3].Trim();

            Reference reference = new Reference(book, chapter, verse);

            return new Scripture(reference, scripturetxt);

        }
        else if (parts.Length == 5)
        {
            string book = parts[0].Trim();
            int chapter = int.Parse(parts[1].Trim());
            int startVerse = int.Parse(parts[2].Trim());
            int EndVerse = int.Parse(parts[3].Trim());

            string scripturetxt = parts[4].Trim();

            Reference reference = new Reference(book, chapter, startVerse, EndVerse);

            return new Scripture(reference, scripturetxt);

        }

        return null;
    }
    public string GetDisplayText()
    {
        string showtext = $"{_reference.GetDisplayText()}\n";
        foreach (Word word in _words)
        {
            showtext += $"{word.GetDisplayText()} ";
        }

        return showtext;
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
}