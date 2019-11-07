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
        private Image _cardImg { get; set; }
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
                            _cardImg = global::Blackjack.Properties.Resources.Ace_of_Hearts;
                            break;
                        case SuiteType.Clubs:
                            _cardImg = global::Blackjack.Properties.Resources.Ace_of_Clubs;
                            break;
                        case SuiteType.Spades:
                            _cardImg = global::Blackjack.Properties.Resources.Ace_of_Spades;
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = global::Blackjack.Properties.Resources.Ace_of_Diamonds;
                            break;
                    }
                    break;
                case CardValue.Two:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = global::Blackjack.Properties.Resources.Two_of_Hearts;
                            break;
                        case SuiteType.Clubs:
                            _cardImg = global::Blackjack.Properties.Resources.Two_of_Clubs;
                            break;
                        case SuiteType.Spades:
                            _cardImg = global::Blackjack.Properties.Resources.Two_of_Spades;
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = global::Blackjack.Properties.Resources.Two_of_Diamonds;
                            break;
                    }
                    break;
                case CardValue.Three:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = global::Blackjack.Properties.Resources.Three_of_Hearts;
                            break;
                        case SuiteType.Clubs:
                            _cardImg = global::Blackjack.Properties.Resources.Three_of_Clubs;
                            break;
                        case SuiteType.Spades:
                            _cardImg = global::Blackjack.Properties.Resources.Three_of_Spades;
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = global::Blackjack.Properties.Resources.Three_of_Diamonds;
                            break;
                    }
                    break;
                case CardValue.Four:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = global::Blackjack.Properties.Resources.Four_of_Hearts;
                            break;
                        case SuiteType.Clubs:
                            _cardImg = global::Blackjack.Properties.Resources.Four_of_Clubs;
                            break;
                        case SuiteType.Spades:
                            _cardImg = global::Blackjack.Properties.Resources.Four_of_Spades;
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = global::Blackjack.Properties.Resources.Four_of_Diamonds;
                            break;
                    }
                    break;
                case CardValue.Five:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = global::Blackjack.Properties.Resources.Five_of_Hearts;
                            break;
                        case SuiteType.Clubs:
                            _cardImg = global::Blackjack.Properties.Resources.Five_of_Clubs;
                            break;
                        case SuiteType.Spades:
                            _cardImg = global::Blackjack.Properties.Resources.Five_of_Spades;
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = global::Blackjack.Properties.Resources.Five_of_Diamonds;
                            break;
                    }
                    break;
                case CardValue.Six:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = global::Blackjack.Properties.Resources.Six_of_Hearts;
                            break;
                        case SuiteType.Clubs:
                            _cardImg = global::Blackjack.Properties.Resources.Six_of_Clubs;
                            break;
                        case SuiteType.Spades:
                            _cardImg = global::Blackjack.Properties.Resources.Six_of_Spades;
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = global::Blackjack.Properties.Resources.Six_of_Diamonds;
                            break;
                    }
                    break;
                case CardValue.Seven:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = global::Blackjack.Properties.Resources.Seven_of_Hearts;
                            break;
                        case SuiteType.Clubs:
                            _cardImg = global::Blackjack.Properties.Resources.Seven_of_Clubs;
                            break;
                        case SuiteType.Spades:
                            _cardImg = global::Blackjack.Properties.Resources.Seven_of_Spades;
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = global::Blackjack.Properties.Resources.Seven_of_Diamonds;
                            break;
                    }
                    break;
                case CardValue.Eight:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = global::Blackjack.Properties.Resources.Eight_of_Hearts;
                            break;
                        case SuiteType.Clubs:
                            _cardImg = global::Blackjack.Properties.Resources.Eight_of_Clubs;
                            break;
                        case SuiteType.Spades:
                            _cardImg = global::Blackjack.Properties.Resources.Eight_of_Spades;
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = global::Blackjack.Properties.Resources.Eight_of_Diamonds;
                            break;
                    }
                    break;
                case CardValue.Nine:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = global::Blackjack.Properties.Resources.Nine_of_Hearts;
                            break;
                        case SuiteType.Clubs:
                            _cardImg = global::Blackjack.Properties.Resources.Nine_of_Clubs;
                            break;
                        case SuiteType.Spades:
                            _cardImg = global::Blackjack.Properties.Resources.Nine_of_Spades;
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = global::Blackjack.Properties.Resources.Nine_of_Diamonds;
                            break;
                    }
                    break;
                case CardValue.Ten:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = global::Blackjack.Properties.Resources.Ten_of_Hearts;
                            break;
                        case SuiteType.Clubs:
                            _cardImg = global::Blackjack.Properties.Resources.Ten_of_Clubs;
                            break;
                        case SuiteType.Spades:
                            _cardImg = global::Blackjack.Properties.Resources.Ten_of_Spades;
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = global::Blackjack.Properties.Resources.Ten_of_Diamonds;
                            break;
                    }
                    break;
                case CardValue.Jack:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = global::Blackjack.Properties.Resources.Jack_of_Hearts;
                            break;
                        case SuiteType.Clubs:
                            _cardImg = global::Blackjack.Properties.Resources.Jack_of_Clubs;
                            break;
                        case SuiteType.Spades:
                            _cardImg = global::Blackjack.Properties.Resources.Jack_of_Spades;
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = global::Blackjack.Properties.Resources.Jack_of_Diamonds;
                            break;
                    }
                    break;
                case CardValue.Queen:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = global::Blackjack.Properties.Resources.Queen_of_Hearts;
                            break;
                        case SuiteType.Clubs:
                            _cardImg = global::Blackjack.Properties.Resources.Queen_of_Clubs;
                            break;
                        case SuiteType.Spades:
                            _cardImg = global::Blackjack.Properties.Resources.Queen_of_Spades;
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = global::Blackjack.Properties.Resources.Queen_of_Diamonds;
                            break;
                    }
                    break;
                case CardValue.King:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = global::Blackjack.Properties.Resources.King_of_Hearts;
                            break;
                        case SuiteType.Clubs:
                            _cardImg = global::Blackjack.Properties.Resources.King_of_Clubs;
                            break;
                        case SuiteType.Spades:
                            _cardImg = global::Blackjack.Properties.Resources.King_of_Spades;
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = global::Blackjack.Properties.Resources.King_of_Clubs;
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

        public Image GetImage()
        {
            return _cardImg;
        }

        public void SetImage(Image CardImage)
        {
            _cardImg = CardImage;
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
