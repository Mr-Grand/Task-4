namespace Task_4;

public class CurrentDeck
{
    private List<Card> _deck = new();

    public List<Card> Deck
    {
        get => _deck;
        private set => _deck = value;
    }

    public void AddCard(Card card)
    {
        _deck.Add(card);
    }

    public void RemoveCard(int index)
    {
        _deck.RemoveAt(index - 1);
    }

    public Card GetCardAtNumber(int number)
    {
        return _deck.ElementAt(number - 1);
    }

    public void ShowCards()
    {
        foreach (Card card in _deck) Console.WriteLine($"{card.Suit} - {card.ValueName}");
    }

    public int GetCount()
    {
        return _deck.Count;
    }
}