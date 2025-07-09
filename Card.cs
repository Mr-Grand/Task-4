namespace Task_4;

public class Card
{
    public string Suit { get; private set; }
    public string ValueName { get; private set; }
    
    public Card(string suit, string value)
    {
        Suit = suit;
        ValueName = value;
    }
}