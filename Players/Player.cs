using lab1;
using lab1.Enums;

namespace Players; 

public class Player {
    public IStrategy Strategy { get; set; }
    public List<CardColor> Cards { get; set; }
    
    public Player(IStrategy strategy) {
        Strategy = strategy;
        Cards = new List<CardColor>();
    }
    
    public int PickCard() {
        return Strategy.Pick();
    }
    
}