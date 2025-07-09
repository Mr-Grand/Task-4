namespace Task_4;

internal class Program
{
    private static void Main(string[] args)
    {
        Deck deck = new();
        Player player = new();
        CurrentDeck currentDeck = new();

        // Заполняем текущую колоду копиями карт
        for (int i = 1; i < deck.GetCount() + 1; i++) currentDeck.AddCard(deck.GetCardAtNumber(i));
        
        // Цикл взятия карт игроком
        string StopWord = null;
        do
        {
            Random random = new();
            Console.WriteLine($"Здравствуйте! Сейчас в колоде {currentDeck.GetCount()} карт!" +
                              $"\nВы можете взять {player.MaxCurrentTakenCount}. Какую выберете?");

            var CardNumber = Console.ReadLine();

            if (CardNumber == "Stop")
            {
                StopWord = CardNumber;
                continue;
            }
            else if (Convert.ToInt32(CardNumber) <= currentDeck.GetCount() && Convert.ToInt32(CardNumber) > 0)
            {
                
                player.TakeCard(currentDeck.GetCardAtNumber(Convert.ToInt32(CardNumber)));
                currentDeck.RemoveCard(Convert.ToInt32(CardNumber));
            }
            else
            {
                Console.WriteLine("Выберите карту из списка!");
                continue;
            }

            player.TakenCount++;
            player.MaxCurrentTakenCount--;
        } while ((player.TakenCount < player.MaxTakenCount) && StopWord != "Stop");

        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Взятые карты:");
        player.ShowCards();
        Console.WriteLine(new string('-', 20));
    }
}