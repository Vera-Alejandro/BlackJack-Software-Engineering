using Blackjack.Data.Enums;
using Blackjack.Data.Properties;
using System.Drawing;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Blackjack.Data
{
    public class Card
    {
        private BitmapImage _cardImg { get; set; }
        private BitmapImage _cardBack { get; set; }

        private CardValue _value { get; set; }
        private SuiteType _suit { get; set; }
        private bool _beenUsed { get; set; }

        public Card( CardValue Value, SuiteType Suit )
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
                            _cardImg = ConvertToBitmapImage( Resources.Ace_of_Hearts );
                            break;
                        case SuiteType.Clubs:
                            _cardImg = ConvertToBitmapImage( Resources.Ace_of_Clubs );
                            break;
                        case SuiteType.Spades:
                            _cardImg = ConvertToBitmapImage( Resources.Ace_of_Spades );
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = ConvertToBitmapImage( Resources.Ace_of_Diamonds );
                            break;
                    }
                    break;
                case CardValue.Two:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = ConvertToBitmapImage( Resources.Two_of_Hearts );
                            break;
                        case SuiteType.Clubs:
                            _cardImg = ConvertToBitmapImage( Resources.Two_of_Clubs );
                            break;
                        case SuiteType.Spades:
                            _cardImg = ConvertToBitmapImage( Resources.Two_of_Spades );
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = ConvertToBitmapImage( Resources.Two_of_Diamonds );
                            break;
                    }
                    break;
                case CardValue.Three:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = ConvertToBitmapImage( Resources.Three_of_Hearts );
                            break;
                        case SuiteType.Clubs:
                            _cardImg = ConvertToBitmapImage( Resources.Three_of_Clubs );
                            break;
                        case SuiteType.Spades:
                            _cardImg = ConvertToBitmapImage( Resources.Three_of_Spades );
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = ConvertToBitmapImage( Resources.Three_of_Diamonds );
                            break;
                    }
                    break;
                case CardValue.Four:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = ConvertToBitmapImage( Resources.Four_of_Hearts );
                            break;
                        case SuiteType.Clubs:
                            _cardImg = ConvertToBitmapImage( Resources.Four_of_Clubs );
                            break;
                        case SuiteType.Spades:
                            _cardImg = ConvertToBitmapImage( Resources.Four_of_Spades );
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = ConvertToBitmapImage( Resources.Four_of_Diamonds );
                            break;
                    }
                    break;
                case CardValue.Five:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = ConvertToBitmapImage( Resources.Five_of_Hearts );
                            break;
                        case SuiteType.Clubs:
                            _cardImg = ConvertToBitmapImage( Resources.Five_of_Clubs );
                            break;
                        case SuiteType.Spades:
                            _cardImg = ConvertToBitmapImage( Resources.Five_of_Spades );
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = ConvertToBitmapImage( Resources.Five_of_Diamonds );
                            break;
                    }
                    break;
                case CardValue.Six:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = ConvertToBitmapImage( Resources.Six_of_Hearts );
                            break;
                        case SuiteType.Clubs:
                            _cardImg = ConvertToBitmapImage( Resources.Six_of_Clubs );
                            break;
                        case SuiteType.Spades:
                            _cardImg = ConvertToBitmapImage( Resources.Six_of_Spades );
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = ConvertToBitmapImage( Resources.Six_of_Diamonds );
                            break;
                    }
                    break;
                case CardValue.Seven:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = ConvertToBitmapImage( Resources.Seven_of_Hearts );
                            break;
                        case SuiteType.Clubs:
                            _cardImg = ConvertToBitmapImage( Resources.Seven_of_Clubs );
                            break;
                        case SuiteType.Spades:
                            _cardImg = ConvertToBitmapImage( Resources.Seven_of_Spades );
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = ConvertToBitmapImage( Resources.Seven_of_Diamonds );
                            break;
                    }
                    break;
                case CardValue.Eight:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = ConvertToBitmapImage( Resources.Eight_of_Hearts );
                            break;
                        case SuiteType.Clubs:
                            _cardImg = ConvertToBitmapImage( Resources.Eight_of_Clubs );
                            break;
                        case SuiteType.Spades:
                            _cardImg = ConvertToBitmapImage( Resources.Eight_of_Spades );
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = ConvertToBitmapImage( Resources.Eight_of_Diamonds );
                            break;
                    }
                    break;
                case CardValue.Nine:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = ConvertToBitmapImage( Resources.Nine_of_Hearts );
                            break;
                        case SuiteType.Clubs:
                            _cardImg = ConvertToBitmapImage( Resources.Nine_of_Clubs );
                            break;
                        case SuiteType.Spades:
                            _cardImg = ConvertToBitmapImage( Resources.Nine_of_Spades );
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = ConvertToBitmapImage( Resources.Nine_of_Diamonds );
                            break;
                    }
                    break;
                case CardValue.Ten:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = ConvertToBitmapImage( Resources.Ten_of_Hearts );
                            break;
                        case SuiteType.Clubs:
                            _cardImg = ConvertToBitmapImage( Resources.Ten_of_Clubs );
                            break;
                        case SuiteType.Spades:
                            _cardImg = ConvertToBitmapImage( Resources.Ten_of_Spades );
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = ConvertToBitmapImage( Resources.Ten_of_Diamonds );
                            break;
                    }
                    break;
                case CardValue.Jack:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = ConvertToBitmapImage( Resources.Jack_of_Hearts );
                            break;
                        case SuiteType.Clubs:
                            _cardImg = ConvertToBitmapImage( Resources.Jack_of_Clubs );
                            break;
                        case SuiteType.Spades:
                            _cardImg = ConvertToBitmapImage( Resources.Jack_of_Spades );
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = ConvertToBitmapImage( Resources.Jack_of_Diamonds );
                            break;
                    }
                    break;
                case CardValue.Queen:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = ConvertToBitmapImage( Resources.Queen_of_Hearts );
                            break;
                        case SuiteType.Clubs:
                            _cardImg = ConvertToBitmapImage( Resources.Queen_of_Clubs );
                            break;
                        case SuiteType.Spades:
                            _cardImg = ConvertToBitmapImage( Resources.Queen_of_Spades );
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = ConvertToBitmapImage( Resources.Queen_of_Diamonds );
                            break;
                    }
                    break;
                case CardValue.King:
                    switch (Suit)
                    {
                        case SuiteType.Hearts:
                            _cardImg = ConvertToBitmapImage( Resources.King_of_Hearts );
                            break;
                        case SuiteType.Clubs:
                            _cardImg = ConvertToBitmapImage( Resources.King_of_Clubs );
                            break;
                        case SuiteType.Spades:
                            _cardImg = ConvertToBitmapImage( Resources.King_of_Spades );
                            break;
                        case SuiteType.Diamonds:
                            _cardImg = ConvertToBitmapImage( Resources.King_of_Clubs );
                            break;
                    }
                    break;
            }

            BitmapImage bitmapImage = new BitmapImage();
            Bitmap CardBack = Resources.Card_Back;
            using (System.IO.MemoryStream memory = new System.IO.MemoryStream())
            {
                CardBack.Save( memory, System.Drawing.Imaging.ImageFormat.Png );
                memory.Position = 0;
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
            }

            _cardBack = bitmapImage;
            #endregion
        }

        public CardValue GetCardValue( ) => _value;

        public void SetCardValue( CardValue Value ) => _value = Value;

        public SuiteType SuiteType => _suit;

        public void SetSuitType( SuiteType Suit ) => _suit = Suit;

        public bool UsedValue => _beenUsed;

        public void SetUsedValue( bool SetCase ) => _beenUsed = SetCase;

        public SuiteType SuiteType1 => _suit;

        public BitmapImage Image
            => _cardImg;

        public BitmapImage BackImage
            => _cardBack;

        public void SetImage( BitmapImage CardImage ) => _cardImg = CardImage;

        internal BitmapImage ConvertToBitmapImage( byte[] ImageBytes )
            => (BitmapImage)(BitmapSource)new ImageSourceConverter().ConvertFrom( ImageBytes );
    }
}