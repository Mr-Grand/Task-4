namespace Task_4;

internal class Program
{
    private static void Main(string[] args)
    {
        Player player = new();
        DeckFactory deckFactory = new();
        Deck deckTemplate = deckFactory.CreateStandardDeck();

        Deck deckCurrent = new();
        // Заполняем текущую колоду копиями карт
        for (int i = 1; i < deckTemplate.GetCount() + 1; i++)
            deckCurrent.AddCard(deckTemplate[i]);

        // Цикл взятия карт игроком
        string? stopWord = null;
        do
        {
            Console.WriteLine($"Здравствуйте! Сейчас в колоде {deckCurrent.GetCount()} карт!" +
                              $"\nВы можете взять {Game.MaxTakenCount - player.TakenCount}. Какую выберете?");
            string? cardNumber = Console.ReadLine();
            if (cardNumber == "Stop")
            {
                stopWord = cardNumber;
                continue;
            }
            else if (Convert.ToInt32(cardNumber) <= deckCurrent.GetCount() && Convert.ToInt32(cardNumber) > 0)
            {
                player.TakeCard(deckCurrent.GetCardAtPosition(Convert.ToInt32(cardNumber)));
                deckCurrent.RemoveCard(Convert.ToInt32(cardNumber));
            }
            else
            {
                Console.WriteLine("Выберите карту из списка!");
                continue;
            }

            player.TakenCount++;
        } while (player.TakenCount < Game.MaxTakenCount && stopWord != "Stop");

        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Взятые карты:");
        player.ShowCards();
        Console.WriteLine(new string('-', 20));
    }
}