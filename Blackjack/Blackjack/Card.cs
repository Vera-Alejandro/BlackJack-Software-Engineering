using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Blackjack
{
    class Card
    {
        public CardValue _value { get; set; }
        public SuiteType _suit {get; private set;}
        public Bitmap _cardImg { get; set; }

        public Card(CardValue Value, SuiteType Suit)
        {
            _value = Value;
            _suit = Suit;
        }

        public enum SuiteType
        {
            Hearts,
            Clubs,
            Spades,
            Diamonds
        }

        public enum CardValue
        { 
            Ace,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 10,
            Queen = 10,
            King = 10         
        }

    }
}
