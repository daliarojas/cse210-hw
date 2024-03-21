using System;

namespace Journal
{
class Entry
{
    public string FullName { get; set; }
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string fullName, DateTime date, string prompt, string response)
    {
        FullName = fullName;
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public void Display()
    {
       Console.WriteLine(FullName);
       Console.WriteLine(Date);
       Console.WriteLine(Prompt);
       Console.WriteLine(Response);
    }
}
}