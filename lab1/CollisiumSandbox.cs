using lab1.Enums;
using lab1.Model;
using Microsoft.Extensions.Hosting;
using Players;
using Shuffler;
using Strategy;

namespace lab1; 

public class CollisiumSandbox {
    public Player Elon { get; }
    public Player Mark { get; }
    public ICardShuffler Shuffler { get; }

    public CardDeck Deck { get; set; }
    
    public CollisiumSandbox(
        IEnumerable<Player> players, 
        IEnumerable<IStrategy> strategies, 
        ICardShuffler shuffler) {
        
        Deck = new CardDeck();
        Console.WriteLine(shuffler);
        var playersArray = players.ToArray();
        Mark = playersArray[0];
        Elon = playersArray[1];

        var strategiesArray = strategies.ToArray();
        Mark.Strategy = strategiesArray[0];
        Elon.Strategy = strategiesArray[1];
        
        Shuffler = shuffler;
    }

    public bool Play() {
        
        Deck = Shuffler.Shuffle(Deck);
        
        DealCards();
        
        return Elon.Cards[Mark.PickCard()] == Mark.Cards[Elon.PickCard()];
    }

    private void DealCards() {
        var deckMidIndex = Deck.GetDeckSize() / 2;
        Elon.Cards = GetCardRangeFromDeck(0, deckMidIndex);
        Mark.Cards = GetCardRangeFromDeck(deckMidIndex, deckMidIndex);
    }

    private List<CardColor> GetCardRangeFromDeck(int fromIndex, int toIndex) {
        return Deck.Cards.GetRange(fromIndex, toIndex);
    }

}