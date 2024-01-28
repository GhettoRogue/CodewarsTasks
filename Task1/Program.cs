var listOfNames = new List<string> { "Ryan", "Kieran", "Mark", "Alice", "Anna", "Tom", "Mike" };

Console.Clear();
FriendOrFoe(listOfNames);

return;

static IEnumerable<string> FriendOrFoe(IEnumerable<string> list)
{
    var findFriends = list.Where(n => n.Length == 4).Order().ToList();

    findFriends.ForEach(Console.WriteLine);

    return findFriends;
}