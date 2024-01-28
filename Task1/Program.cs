var listOfNames = new List<string> { "Ryan", "Kieran", "Mark" };

foreach (var friends in FriendOrFoe(listOfNames))
{
    Console.WriteLine(friends);
}

return;

IEnumerable<string> FriendOrFoe(IEnumerable<string> names)
{
    return names.Where(n => n.Length == 4).ToList();
}
