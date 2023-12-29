using lab1;
using lab1.Model;

namespace Shuffler;

public class FisherCardShuffler : ICardShuffler{

    private readonly Random _random = new();
    
    public CardDeck Shuffle(CardDeck deck) {
        for (var i = deck.GetDeckSize() - 1; i > 0; i--) {
            var j = _random.Next(0, i);
            (deck.Cards[i], deck.Cards[j]) = (deck.Cards[j], deck.Cards[i]);
        }
        return deck;
    }
}
