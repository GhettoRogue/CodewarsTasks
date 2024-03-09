Console.Clear();

Console.WriteLine(AbbrevName(""));

Console.WriteLine(AbbrevName("john doe"));
Console.WriteLine(AbbrevName("John Doe"));
Console.WriteLine(AbbrevName("Evan Cole"));
Console.WriteLine(AbbrevName("P Favuzzi"));
Console.WriteLine(AbbrevName("David Mendieta"));

return;

string AbbrevName(string name)
{
    if (name.Length == 0)
        return string.Empty;
    for (var i = 0; i < name.Length; i++)
    {
        if (name[i] == ' ')
        {
            return name.ToUpper()[0] + "." + name.ToUpper()[i + 1];
        }
    }

    return name;
}