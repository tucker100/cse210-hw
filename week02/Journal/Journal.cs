public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            Console.WriteLine();
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToFileString());
            }
        }

        Console.WriteLine($"Journal saved to {fileName}.");
    }

    public void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine($"Could not find a file named {fileName}.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            if (line.Trim() != "")
            {
                _entries.Add(Entry.FromFileString(line));
            }
        }

        Console.WriteLine($"Loaded {_entries.Count} entries from {fileName}.");
    }
}