using System.Text.RegularExpressions;

const string pattern = "[aeiouAEIOU]";
const string replacement = "!";

Console.WriteLine(Replace("Hi!"));
Console.WriteLine(Replace("!Hi! Hi!"));
Console.WriteLine(Replace("ABCDE"));

return;

static string Replace(string str)
{
    return Regex.Replace(str, pattern, replacement);
}