using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BlackjackGame
{
    public class Card
    {
        private CardValue _value { get; set; }
        private SuiteType _suit {get; set;}
        private Bitmap _cardImg { get; set; }
        private bool _beenUsed { get; set; }

        public Card(CardValue Value, SuiteType Suit)
        {
            _value = Value;
            _suit = Suit;
            _beenUsed = false;
        }

        public CardValue GetCardValue()
        {
            return _value;
        }

        public void SetCardValue(CardValue Value)
        {
            _value = Value;
        }

        public SuiteType GetSuiteType()
        {
            return _suit;
        }

        public void SetSuitType(SuiteType Suit)
        {
            _suit = Suit;
        }

        public bool GetUsedValue()
        {
            return _beenUsed;
        }

        public void SetUsedValue(bool SetCase)
        {
            _beenUsed = SetCase;
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
