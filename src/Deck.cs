public class Deck
{
    private Card[] cards;

    public Deck(int jokers = 0)
    {
        cards = new [] { Suit.Spade, Suit.Club, Suit.Diam, Suit.Heart, }
                .SelectMany(
                    suit => Enumerable.Range(1, 13),
                    (suit, rank) => new Card(rank, suit))
                .ToArray();

        // TODO: Add Joker
    }

    public void Shuffle()
    {
        cards = cards.Shuffle().ToArray();
    }

    public Card[] Draw(int number)
    {
        return this.cards.Take(number);
    }
}

public static class IEnumerableExtension
{
    public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> collection)
    {
        return collection.OrderBy(i => Guid.NewGuid());
    }
}
