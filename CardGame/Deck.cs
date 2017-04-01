using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Deck
    {
        private List<int> _deck;
        private static Random _random = new Random();
        private List<int> _playerOneCards;
        private List<int> _playerTwoCards;
        private List<int> _discardPile;
        private List<int> _drawPile;
        public Deck()
        {
            _deck = new List<int>();
        }
        public List<int> getDeck()
        {   
            for (int i = 1; i < 11; i++)
            {
                _deck.Add(i);
                _deck.Add(i);

            }
            Shuffle(_deck);
            return _deck;
        }
        public void Shuffle(List<int> deck)
        {
            int n = deck.Count;
            while(n > 1)
            {
                n--;
                int k = _random.Next(n + 1);
                int value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }
        public List<int> getPlayerOneCards()
        {
            _playerOneCards =_deck.GetRange(0, 5);
            foreach(int card in _playerOneCards)
            {
                Console.WriteLine(card);
            }
            return _playerOneCards;
        }
        public List<int> getPlayerTwoCards()
        {
            _playerTwoCards = _deck.GetRange(5, 5);
            foreach(int card in _playerTwoCards)
            {
                Console.WriteLine(card);
            }
            return _playerTwoCards;
        }
        public List<int> getDiscardPile()
        {
            _discardPile = _deck.GetRange(10, 1);
            Console.WriteLine(_discardPile[0]);
            return _discardPile;
        }
        public List<int> getDrawPile()
        {
            _drawPile = _deck.GetRange(11, 9);
            foreach(int draw in _drawPile)
            {
                Console.WriteLine(draw);
            }
            return _drawPile;
        }
    }

}
