namespace Task_4;

public class Player
{
    private List<Card> _takenCards = new();
    private int _takenCount = 0;
    private int _maxCurrentTakenCount = 4;
    private int _maxTakenCount = 4;

    public int TakenCount
    {
        get => _takenCount;
        set => _takenCount = value;
    }

    public int MaxTakenCount
    {
        get => _maxTakenCount;
        set => _maxTakenCount = value;
    }

    public int MaxCurrentTakenCount
    {
        get => _maxCurrentTakenCount;
        set => _maxCurrentTakenCount = value;
    }

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