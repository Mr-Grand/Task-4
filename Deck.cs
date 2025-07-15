namespace Task_4;

public class Deck
{
    private List<Card> _cardsDeck = new ();

    public int GetCount()
    {
        return _cardsDeck.Count;
    }

    public Card GetCardAtNumber(int number)
    {
        return _cardsDeck.ElementAt(number - 1);
    }
    
    public void AddCard(Card card)
    {
        _cardsDeck.Add(card);
    }

    public void RemoveCard(int index)
    {
        _cardsDeck.RemoveAt(index - 1);
    }
}