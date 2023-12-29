using System;
using System.Collections.Generic;
using lab1.Enums;

namespace lab1.Model;

public class CardDeck {
    public List<CardColor> Cards { get; }
    private int DeckSize { get; }
    private readonly int _totalCardTypes = Enum.GetNames(typeof(CardColor)).Length;


    public CardDeck(List<CardColor> cards) {
        Cards = cards;
        DeckSize = cards.Count;
    }
    
    public CardDeck(int deckSize = 36) {//Магические константы давай хранить в одном месте (appsetting.json)
        DeckSize = deckSize;
        
        Cards = new List<CardColor>();
        if (deckSize % _totalCardTypes != 0) {
            throw new Exception("deck size must be even");
        }
        for (var i = 0; i < deckSize / 2; i++) {
            Cards.Add(CardColor.Red);
            Cards.Add(CardColor.Black);
        }
    }

    public int GetDeckSize() {
        return DeckSize;
    }
    
    
}