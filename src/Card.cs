public class Card
{
    public Suit Suit;

    // 1-13
    public int Rank;

    public Card(Suit suit, int rank)
    {
        this.Suit = suit;
        this.Rank = rank;
    }
}

public enum Suit
{
    Spade,
    Club,
    Diam,
    Heart,
}
