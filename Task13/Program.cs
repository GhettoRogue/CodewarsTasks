using System.Text;

Console.WriteLine(ToAlternatingCase("hello world"));
Console.WriteLine(ToAlternatingCase("1a2b3c4d5e"));
Console.WriteLine(ToAlternatingCase("HeLLo WoRLD"));
Console.WriteLine(ToAlternatingCase("String.ToAlternatingCase"));

return;

static string ToAlternatingCase(string s)
{
    var result = new StringBuilder();
    foreach (var item in s)
    {
        if (char.IsLetter(item))
        {
            result.Append(char.IsUpper(item)
                ? char.ToLower(item)
                : char.ToUpper(item));
        }
        else
        {
            result.Append(item);
        }
    }

    return result.ToString();
}