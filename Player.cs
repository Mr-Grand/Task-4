namespace Task_4;

public class Player
{
    private List<Card> _takenCards = new();
    
    public int TakenCount { get; set; } = 0;

    public void TakeCard(Card card)
    {
        _takenCards.Add(card);
    }

    public void ShowCards()
    {
        foreach (Card card in _takenCards)
            Console.WriteLine($"{card.Suit} - {card.ValueName}");
    }
}