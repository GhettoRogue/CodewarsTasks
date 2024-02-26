string[] Deck =
[
    "2♣", "3♣", "4♣", "5♣", "6♣", "7♣", "8♣", "9♣", "10♣", "J♣", "Q♣", "K♣", "A♣",
    "2♦", "3♦", "4♦", "5♦", "6♦", "7♦", "8♦", "9♦", "10♦", "J♦", "Q♦", "K♦", "A♦",
    "2♥", "3♥", "4♥", "5♥", "6♥", "7♥", "8♥", "9♥", "10♥", "J♥", "Q♥", "K♥", "A♥",
    "2♠", "3♠", "4♠", "5♠", "6♠", "7♠", "8♠", "9♠", "10♠", "J♠", "Q♠", "K♠", "A♠"
];

ShowSuit(card:"10♠");

return;

string DefineSuit(string card)
{
    var suitSymbol = card[^1];

    return suitSymbol switch
    {
        '♣' => "clubs",
        '♦' => "diamonds",
        '♥' => "hearts",
        '♠' => "spades",
        _ => throw new ArgumentException("Invalid card: " + card)
    };
}

void ShowSuit(string card)
{
    var suit = DefineSuit(card);
    var rank = card[..^1];

    Console.Clear();
    Console.WriteLine($"{rank} of {suit}.");
}