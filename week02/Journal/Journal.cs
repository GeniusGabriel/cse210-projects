// SHOWING CREATIVITY: I added a method called GetEntryCount() to the Journal class. This method returns the number of entries currently stored in the journal. It can be useful for displaying the total number of entries to the user or for other purposes where knowing the count of entries is necessary.
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
    public int GetEntryCount()
    {
        return _entries.Count;
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(
                    $"{entry._date}|{entry._prompt}|{entry._response}"
                );
            }
        }

        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 3)
            {
                Entry entry = new Entry(
                    parts[0],
                    parts[1],
                    parts[2]
                );

                _entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded successfully!");
    }
}
