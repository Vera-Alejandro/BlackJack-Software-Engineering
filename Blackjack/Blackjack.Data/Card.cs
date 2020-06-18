using Blackjack.Data.Enums;

namespace Blackjack.Data
{
    public class Card
    {
                //FIND A REPLACEMENT FOR IMAGES IN .NETCORE 3.1
        //private Image _cardImg { get; set; }
        //private Image _cardBack { get; set; }
        
        private CardValue _value { get; set; }
        private SuiteType _suit { get; set; }
        private bool _beenUsed { get; set; }

        public Card( CardValue Value, SuiteType Suit )
        {
            _value = Value;
            _suit = Suit;
            _beenUsed = false;

            #region Set Card Image
            /*

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
            _cardBack = global::Blackjack.Properties.Resources.Card_Back;
             */
            #endregion
        }

        public CardValue GetCardValue( ) => _value;

        public void SetCardValue( CardValue Value ) => _value = Value;

        public SuiteType SuiteType => _suit;

        public void SetSuitType( SuiteType Suit ) => _suit = Suit;

        public bool UsedValue => _beenUsed;

        public void SetUsedValue( bool SetCase ) => _beenUsed = SetCase;

        public SuiteType SuiteType1 => _suit;

        //public Image Image => _cardImg;

        //public Image BackImage => _cardBack;

        //public void SetImage( Image CardImage ) => _cardImg = CardImage;
    }
}