using lab1.Model;

namespace lab1; 

public interface ICardShuffler {
    CardDeck Shuffle(CardDeck deck);
}