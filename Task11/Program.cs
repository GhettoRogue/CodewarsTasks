Console.Clear();
Console.WriteLine(Greet("riley"));
Console.WriteLine(Greet("JACK"));

return;

string Greet(string name) => $"Hello {char.ToUpper(name[0]) + name[1..].ToLower()}!";
