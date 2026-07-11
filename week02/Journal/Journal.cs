using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}| {entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine("File Saved Successfully");
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];

            Entry loadedEntry = new Entry();
            loadedEntry._date = date;
            loadedEntry._promptText = prompt;
            loadedEntry._entryText = entry;

            _entries.Add(loadedEntry);

        }
        Console.WriteLine("File Loaded Successfully");

    }
}