using System;
using System.IO;
using System.Runtime.InteropServices;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        // Console.WriteLine($"Entry: {_entries}");
        // foreach (Entry e in _entries)
        // {
        //     e.Display();
        // }
    }

    public void DisplayAll()
    {

        if (_entries.Count > 0)
        {
            foreach (Entry e in _entries)
            {
                e.Display();
            }
        }
        else
        {
            Console.WriteLine("Entries list is empty");
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // You can add text to the file with the WriteLine method
            //outputFile.WriteLine("This will be the first line in the file.");

            // You can use the $ and include variables just like with Console.WriteLine

            for (int i = 0; i < _entries.Count; i++)
            {
                string date = _entries[i]._date;
                string prompt = _entries[i]._promptText;
                string entry_txt = _entries[i]._entryText;
                outputFile.WriteLine($"{date}~|~{prompt}~|~{entry_txt}~|~");
            }
        }

    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            string date = parts[0];
            string prompt = parts[1];
            string txt_entry = parts[2];
            
            Entry newEntry = new Entry();
            newEntry._date = date;
            newEntry._promptText = prompt;
            newEntry._entryText = txt_entry;
            AddEntry(newEntry);

        }
    }
}