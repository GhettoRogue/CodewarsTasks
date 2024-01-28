var haystack = new object[] { "hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk" };

PrintFoundNeedle(FindNeedle(haystack));

return;

static string FindNeedle(object[] list)
{
    const string message = "Found the needle at position: ";
    const string needle = "needle";

    return message + Array.IndexOf(list, needle);
}

void PrintFoundNeedle(string obj)
{
    Console.Clear();
    Console.WriteLine(obj);
}