var haystack = new object[] { "hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk" };

Console.Clear();
foreach (var item in FindNeedle(haystack))
{
    Console.Write(item);
}

return;

static string FindNeedle(object[] list)
{
    const string message = "Found the needle at position: ";
    const string needle = "needle";

    return message + Array.IndexOf(list, needle);
}