namespace Task_4;

public class Deck
{
    private List<Card> _cardsDeck = new();

    public int GetCount()
    {
        return _cardsDeck.Count;
    }

    public Card this[int index]
    {
        get => _cardsDeck[index];
        set => _cardsDeck[index] = value;
    }

    public Card GetCardAtPosition(int position)
    {
        if (position >= 1 && position <= _cardsDeck.Count)
        {
            return _cardsDeck.ElementAt(position - 1);
        }
        else
        {
            Console.WriteLine("Invalid position");
            return new Card("None", "0");
        }
    }

    public void AddCard(Card card)
    {
        _cardsDeck.Add(card);
    }

    public void RemoveCard(int position)
    {
        _cardsDeck.RemoveAt(position - 1);
    }
}