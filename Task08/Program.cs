var words = new [] {"bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps"};

OutputToConsoleUsingSort(words);

return;

string TwoSort(string[] s)
{
    var sorted = s.OrderBy(str => str).ToArray();

    var first = sorted.First();
  
    var firstChars = first.ToCharArray();

    return string.Join("***", firstChars);
}

void OutputToConsoleUsingSort(string[] s)
{
    Console.Clear();
    foreach (var item in TwoSort(s))
    {
        Console.Write(item);
    }
}

/*string TwoSortAsSeparator(string[] s, string separator)
{
    var sorted = s.OrderBy(str => str).ToArray();

    var first = sorted.First();
  
    var firstChars = first.ToCharArray();

    return string.Join(separator, firstChars);
}*/
