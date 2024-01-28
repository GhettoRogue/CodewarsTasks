const string sentence = "Turns out random test cases are easier than writing out basic ones";

var shortestWord = FindShort(sentence);
Console.WriteLine(sentence);
Console.WriteLine("The length of the shortest word is: " + shortestWord);

return;

static int FindShort(string sentence)
{
    var words = sentence.Split().Min(s => s.Length);

    return words;
}