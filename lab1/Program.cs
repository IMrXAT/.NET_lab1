using Strategy;

namespace lab1; 

class Solution {
    static void Main(string[] args) {
        const int numExperiments = 1_000_000;
        IStrategy firstCardStrategy = new FirstCardStrategy();
        IStrategy secondCardStrategy = new SecondStrategy();
        
        var player1 = new Player(firstCardStrategy);
        var player2 = new Player(secondCardStrategy);

        var deck = new CardDeck();

        var shaffler = new FisherCardShuffler();
        var gameSession = new Game(player1, player2, deck, shaffler);
        int winCount = 0;
        for (int i = 0; i < numExperiments; i++) {
            if (gameSession.Play()) {
                winCount++;
            }
        }
        System.Console.WriteLine((double)winCount/numExperiments);
    }
}