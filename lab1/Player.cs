namespace lab1; 

public class Player {
    private IStrategy _strategy;
    private List<CardColor> _cards;
    public Player(IStrategy strategy) {
        _strategy = strategy;
    }

    public IStrategy GetStrategy() {
        return _strategy;
    }

    public void SetCards(List<CardColor> playersCards) {
        this._cards = playersCards;
    }

    public List<CardColor> GetCards() {
        return _cards;
    }
}