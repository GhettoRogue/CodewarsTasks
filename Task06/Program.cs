const string sentence = "The count of occurrences: ";

Console.WriteLine($"{sentence}{StrCount("Hello", 'o')}");
Console.WriteLine($"{sentence}{StrCount("Hello", 'l')}");
Console.WriteLine($"{sentence}{StrCount("", 'z')}");

return;

int StrCount(string str, char letter)
{
    return str.Count(l => l == letter);
}

/*int StrCountUsingForLoop(string str, char letter)
{
    var count = 0;

    for (var i = 0; i < str.Length; i++)
    {
        if (str[i] == letter)
        {
            count++;
        }
    }

    return count;
}*/