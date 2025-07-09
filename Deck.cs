namespace Task_4;

public class Deck
{
    private Card[] _cardsDeck =
    {
        new("Diamonds", "T"),
        new("Diamonds", "K"),
        new("Diamonds", "J"),
        new("Diamonds", "Q"),
        new("Diamonds", "10"),
        new("Diamonds", "9"),
        new("Diamonds", "8"),
        new("Diamonds", "7"),
        new("Diamonds", "6"),
        new("Hearts", "T"),
        new("Hearts", "K"),
        new("Hearts", "J"),
        new("Hearts", "Q"),
        new("Hearts", "10"),
        new("Hearts", "9"),
        new("Hearts", "8"),
        new("Hearts", "7"),
        new("Hearts", "6"),
        new("Spades", "T"),
        new("Spades", "K"),
        new("Spades", "J"),
        new("Spades", "Q"),
        new("Spades", "10"),
        new("Spades", "9"),
        new("Spades", "8"),
        new("Spades", "7"),
        new("Spades", "6"),
        new("Clubs", "T"),
        new("Clubs", "K"),
        new("Clubs", "J"),
        new("Clubs", "Q"),
        new("Clubs", "10"),
        new("Clubs", "9"),
        new("Clubs", "8"),
        new("Clubs", "7"),
        new("Clubs", "6")
    };

    public int GetCount()
    {
        return _cardsDeck.Length;
    }

    public Card GetCardAtNumber(int number)
    {
        return _cardsDeck.ElementAt(number - 1);
    }
}