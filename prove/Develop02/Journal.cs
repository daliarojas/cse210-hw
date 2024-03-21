using System;
namespace Journal
{
class Journnal
 { 
    private List<Entry> _entries;  

    public Journnal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry(Entry entry)
    {
       _entries.Add(entry);
    }
    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry.FullName + ", " + entry.Date.ToString() + ", " + entry.Prompt + ", " + entry.Response);
          
        }
    }

    public void SaveToFile(string fileName)
    {
        using(StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry.FullName},{entry.Date},{entry.Prompt},{entry.Response}");
                }
            }
        }

        public void LoadFromFile(string filename)
        {
            _entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');   
                    if (parts.Length == 4 && DateTime.TryParse(parts[1], out DateTime date))
                    {
                        _entries.Add(new Entry(parts[0], date, parts[2], parts[3]));
                    }
                }
            }
        }

    
    }  
}

        
   