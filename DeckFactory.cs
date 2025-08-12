namespace Task_4;

public class DeckFactory
{
    public Deck CreateStandardDeck()
    {
        Deck standardDeck = new();

        standardDeck.AddCard(new Card("Diamonds", "T"));
        standardDeck.AddCard(new Card("Diamonds", "K"));
        standardDeck.AddCard(new Card("Diamonds", "J"));
        standardDeck.AddCard(new Card("Diamonds", "Q"));
        standardDeck.AddCard(new Card("Diamonds", "10"));
        standardDeck.AddCard(new Card("Diamonds", "9"));
        standardDeck.AddCard(new Card("Diamonds", "8"));
        standardDeck.AddCard(new Card("Diamonds", "7"));
        standardDeck.AddCard(new Card("Diamonds", "6"));
        standardDeck.AddCard(new Card("Hearts", "T"));
        standardDeck.AddCard(new Card("Hearts", "K"));
        standardDeck.AddCard(new Card("Hearts", "J"));
        standardDeck.AddCard(new Card("Hearts", "Q"));
        standardDeck.AddCard(new Card("Hearts", "10"));
        standardDeck.AddCard(new Card("Hearts", "9"));
        standardDeck.AddCard(new Card("Hearts", "8"));
        standardDeck.AddCard(new Card("Hearts", "7"));
        standardDeck.AddCard(new Card("Hearts", "6"));
        standardDeck.AddCard(new Card("Spades", "T"));
        standardDeck.AddCard(new Card("Spades", "K"));
        standardDeck.AddCard(new Card("Spades", "J"));
        standardDeck.AddCard(new Card("Spades", "Q"));
        standardDeck.AddCard(new Card("Spades", "10"));
        standardDeck.AddCard(new Card("Spades", "9"));
        standardDeck.AddCard(new Card("Spades", "8"));
        standardDeck.AddCard(new Card("Spades", "7"));
        standardDeck.AddCard(new Card("Spades", "6"));
        standardDeck.AddCard(new Card("Clubs", "T"));
        standardDeck.AddCard(new Card("Clubs", "K"));
        standardDeck.AddCard(new Card("Clubs", "J"));
        standardDeck.AddCard(new Card("Clubs", "Q"));
        standardDeck.AddCard(new Card("Clubs", "10"));
        standardDeck.AddCard(new Card("Clubs", "9"));
        standardDeck.AddCard(new Card("Clubs", "8"));
        standardDeck.AddCard(new Card("Clubs", "7"));
        standardDeck.AddCard(new Card("Clubs", "6"));

        return standardDeck;
    }
}