using lab1.Enums;
using lab1.Model;
using NUnit.Framework;
using Xunit;

namespace tests;

public class DeckTests {
    private int DECK_SIZE = 36;

    [Fact]
    public void Test18Black18Red() {
        var deck = new CardDeck();
        
        var redCardCount = deck.Cards.Count(card => card == CardColor.Red);
        var blackCardCount = deck.Cards.Count(card => card == CardColor.Black);
        Assert.Equals(redCardCount, DECK_SIZE / 2);
        Assert.Equals(blackCardCount, DECK_SIZE / 2);
    }
}