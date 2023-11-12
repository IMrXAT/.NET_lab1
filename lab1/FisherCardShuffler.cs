namespace lab1;


class FisherCardShuffler : ICardShuffler{

    public CardDeck Shuffle(CardDeck deck) {
        Random random = new Random();
        for (int i = deck.GetDeckSize() - 1; i > 0; i--) {
            int j = random.Next(0, i);
            (deck.GetCards()[i], deck.GetCards()[j]) = (deck.GetCards()[j], deck.GetCards()[i]);
        }
        return deck;
    }
}

