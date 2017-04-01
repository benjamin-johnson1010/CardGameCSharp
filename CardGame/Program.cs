using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {   
               
            Deck deck = new Deck();
            deck.getDeck();
            deck.getPlayerOneCards();
            deck.getPlayerTwoCards();
            deck.getDiscardPile();
            deck.getDrawPile();
        }
    }
}
