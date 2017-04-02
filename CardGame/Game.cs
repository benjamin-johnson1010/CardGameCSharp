using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Game
    {
        private List<int> _playerOneCards;
        private List<int> _playerTwoCards;
        private List<int> _discardPile;
        private List<int> _drawPile;
        private Dictionary<String, String> _Menu;
        public Game(List<int> playerOneCards, List<int> playerTwoCards, List<int> discardPile, List<int> drawPile)
        {
            _playerOneCards = playerOneCards;
            _playerTwoCards = playerTwoCards;
            _discardPile = discardPile;
            _drawPile = drawPile;
            _Menu.Add("play", "Play a card");
            _Menu.Add("draw", "Draw a card");
            _Menu.Add("show", "Display Hand");

        }

    }
}
