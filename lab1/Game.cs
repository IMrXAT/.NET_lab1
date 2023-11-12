namespace lab1;

class Game {
    private Player _player1;
    private Player _player2;
    private CardDeck _deck;
    private ICardShuffler _shuffler;

    public Game(Player player1, Player player2, CardDeck deck, ICardShuffler shuffler) {
        _player1 = player1;
        _player2 = player2;
        _deck = deck;
        _shuffler = shuffler;
    }

    public bool Play() {
        _deck = _shuffler.Shuffle(_deck);
        // Console.WriteLine(_deck);
        DealCards();
        // foreach (var card  in _player1.GetCards()) {
        //     Console.Write(card + " ");
        // }
        // Console.WriteLine();
        // foreach (var card  in _player2.GetCards()) {
        //     Console.Write(card + " ");
        // }
        // Console.WriteLine();
        return _player1.GetCards()[_player1.GetStrategy().Pick()] == _player2.GetCards()[_player2.GetStrategy().Pick()];
    }

    private void DealCards() {
        _player1.SetCards(_deck.GetCards().GetRange(0, 16));
        _player2.SetCards(_deck.GetCards().GetRange(16, 16));
    }
}