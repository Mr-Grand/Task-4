namespace Task_4;

internal class Program
{
    private static void Main(string[] args)
    {
        Player player = new();
        
        Deck deckTemplate = new();
        deckTemplate.AddCard(new Card("Diamonds", "T"));
        deckTemplate.AddCard(new Card("Diamonds", "K"));
        deckTemplate.AddCard(new Card("Diamonds", "J"));
        deckTemplate.AddCard(new Card("Diamonds", "Q"));
        deckTemplate.AddCard(new Card("Diamonds", "10"));
        deckTemplate.AddCard(new Card("Diamonds", "9"));
        deckTemplate.AddCard(new Card("Diamonds", "8"));
        deckTemplate.AddCard(new Card("Diamonds", "7"));
        deckTemplate.AddCard(new Card("Diamonds", "6"));
        deckTemplate.AddCard(new Card("Hearts", "T"));
        deckTemplate.AddCard(new Card("Hearts", "K"));
        deckTemplate.AddCard(new Card("Hearts", "J"));
        deckTemplate.AddCard(new Card("Hearts", "Q"));
        deckTemplate.AddCard(new Card("Hearts", "10"));
        deckTemplate.AddCard(new Card("Hearts", "9"));
        deckTemplate.AddCard(new Card("Hearts", "8"));
        deckTemplate.AddCard(new Card("Hearts", "7"));
        deckTemplate.AddCard(new Card("Hearts", "6"));
        deckTemplate.AddCard(new Card("Spades", "T"));
        deckTemplate.AddCard(new Card("Spades", "K"));
        deckTemplate.AddCard(new Card("Spades", "J"));
        deckTemplate.AddCard(new Card("Spades", "Q"));
        deckTemplate.AddCard(new Card("Spades", "10"));
        deckTemplate.AddCard(new Card("Spades", "9"));
        deckTemplate.AddCard(new Card("Spades", "8"));
        deckTemplate.AddCard(new Card("Spades", "7"));
        deckTemplate.AddCard(new Card("Spades", "6"));
        deckTemplate.AddCard(new Card("Clubs", "T"));
        deckTemplate.AddCard(new Card("Clubs", "K"));
        deckTemplate.AddCard(new Card("Clubs", "J"));
        deckTemplate.AddCard(new Card("Clubs", "Q"));
        deckTemplate.AddCard(new Card("Clubs", "10"));
        deckTemplate.AddCard(new Card("Clubs", "9"));
        deckTemplate.AddCard(new Card("Clubs", "8"));
        deckTemplate.AddCard(new Card("Clubs", "7"));
        deckTemplate.AddCard(new Card("Clubs", "6"));
        
        Deck deckCurrent = new();
        // Заполняем текущую колоду копиями карт
        for (int i = 1; i < deckTemplate.GetCount() + 1; i++) 
            deckCurrent.AddCard(deckTemplate.GetCardAtNumber(i));
        
        // Цикл взятия карт игроком
        string? stopWord = null;
        do
        {
            Console.WriteLine($"Здравствуйте! Сейчас в колоде {deckCurrent.GetCount()} карт!" +
                              $"\nВы можете взять {Game.MAX_TAKEN_COUNT - player.TakenCount}. Какую выберете?");
            string? cardNumber = Console.ReadLine();
            if (cardNumber == "Stop")
            {
                stopWord = cardNumber;
                continue;
            }
            else if (Convert.ToInt32(cardNumber) <= deckCurrent.GetCount() && Convert.ToInt32(cardNumber) > 0)
            {
                player.TakeCard(deckCurrent.GetCardAtNumber(Convert.ToInt32(cardNumber)));
                deckCurrent.RemoveCard(Convert.ToInt32(cardNumber));
            }
            else
            {
                Console.WriteLine("Выберите карту из списка!");
                continue;
            }
            player.TakenCount++;
        } while (player.TakenCount < Game.MAX_TAKEN_COUNT && stopWord != "Stop");

        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Взятые карты:");
        player.ShowCards();
        Console.WriteLine(new string('-', 20));
    }
}