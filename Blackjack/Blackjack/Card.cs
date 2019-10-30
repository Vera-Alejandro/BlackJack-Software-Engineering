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

            #region Set Card Image

            switch (Value)
            {
                case CardValue.Ace:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            break;
                        case SuiteType.Clubs:
                            _cardImg = global::Blackjack.Properties.Resources.Ace_of_Clubs;
                            break;
                        case SuiteType.Spades:
                            break;
                        case SuiteType.Diamonds:
                            break;
                    }
                    break;
                case CardValue.Two:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            break;
                        case SuiteType.Clubs:
                            break;
                        case SuiteType.Spades:
                            break;
                        case SuiteType.Diamonds:
                            break;
                    }
                    break;
                case CardValue.Three:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            break;
                        case SuiteType.Clubs:
                            break;
                        case SuiteType.Spades:
                            break;
                        case SuiteType.Diamonds:
                            break;
                    }
                    break;
                case CardValue.Four:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            break;
                        case SuiteType.Clubs:
                            break;
                        case SuiteType.Spades:
                            break;
                        case SuiteType.Diamonds:
                            break;
                    }
                    break;
                case CardValue.Five:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            break;
                        case SuiteType.Clubs:
                            break;
                        case SuiteType.Spades:
                            break;
                        case SuiteType.Diamonds:
                            break;
                    }
                    break;
                case CardValue.Six:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            break;
                        case SuiteType.Clubs:
                            break;
                        case SuiteType.Spades:
                            break;
                        case SuiteType.Diamonds:
                            break;
                    }
                    break;
                case CardValue.Seven:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            break;
                        case SuiteType.Clubs:
                            break;
                        case SuiteType.Spades:
                            break;
                        case SuiteType.Diamonds:
                            break;
                    }
                    break;
                case CardValue.Eight:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            break;
                        case SuiteType.Clubs:
                            break;
                        case SuiteType.Spades:
                            break;
                        case SuiteType.Diamonds:
                            break;
                    }
                    break;
                case CardValue.Nine:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            break;
                        case SuiteType.Clubs:
                            break;
                        case SuiteType.Spades:
                            break;
                        case SuiteType.Diamonds:
                            break;
                    }
                    break;
                case CardValue.Ten:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            break;
                        case SuiteType.Clubs:
                            break;
                        case SuiteType.Spades:
                            break;
                        case SuiteType.Diamonds:
                            break;
                    }
                    break;
                case CardValue.Jack:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            break;
                        case SuiteType.Clubs:
                            break;
                        case SuiteType.Spades:
                            break;
                        case SuiteType.Diamonds:
                            break;
                    }
                    break;
                case CardValue.Queen:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            break;
                        case SuiteType.Clubs:
                            break;
                        case SuiteType.Spades:
                            break;
                        case SuiteType.Diamonds:
                            break;
                    }
                    break;
                case CardValue.King:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            break;
                        case SuiteType.Clubs:
                            break;
                        case SuiteType.Spades:
                            break;
                        case SuiteType.Diamonds:
                            break;
                    }
                    break;
            }

            #endregion
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
            Two,
            Three,
            Four, 
            Five, 
            Six,
            Seven,
            Eight,
            Nine, 
            Ten, 
            Jack, 
            Queen,
            King        
        }

    }
}
