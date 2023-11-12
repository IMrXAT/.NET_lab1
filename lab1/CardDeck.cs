namespace lab1;

public class CardDeck {
    private List<CardColor> _cards;
    private readonly int _deckSize;
    private readonly int _totalCardTypes = Enum.GetNames(typeof(CardColor)).Length;

    public CardDeck(int deckSize = 36) {
        _deckSize = deckSize;
        
        _cards = new List<CardColor>();
        if (deckSize % _totalCardTypes != 0) {
            throw new Exception("deck size must be even");
        }
        for (int i = 0; i < deckSize / 2; i++) {
            _cards.Add(CardColor.Red);
            _cards.Add(CardColor.Black);
        }
    }

    public int GetDeckSize() {
        return _deckSize;
    }

    public List<CardColor> GetCards() {
        return _cards;
    }
    
}