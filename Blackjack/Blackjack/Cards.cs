using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Blackjack
{
    class Cards
    {
        public int _value { get; set; }
        public SuiteType _suit {get; private set;}
        public Bitmap _cardImg { get; set; }

        public Cards(int Value, SuiteType Suit)
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
    }
}
