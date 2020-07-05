using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame21
{
    public class Deck
    {
        public List<Card> _deck;
        private Random _random;
        private StringBuilder _sb;
        public Deck()
        {
            _sb = new StringBuilder();
            _random = new Random();
            _deck = new List<Card>();
            CardType[] cards = new CardType[] {CardType.Karo, CardType.Kupa , CardType.Maca , CardType.Sinek};
            Game[] games = new Game[] {Game.Jack};
            foreach (var suit in cards)
            {
                foreach (var kind in games)
                {
                    _deck.Add(new Card { Games = kind, CardType = suit });
                }
            }
        }
    }
}
