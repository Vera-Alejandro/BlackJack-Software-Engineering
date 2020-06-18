using Blackjack.Data.Enums;
using System.Collections.Generic;

namespace Blackjack.Data
{
    public class Hand
    {
        private int _handTotal { get; set; }
        private List<Card> _currentHand { get; set; }

        public Hand( )
        {
            _currentHand = new List<Card>();
            _handTotal = 0;
        }

        public int GetTotal( ) => _handTotal;

        public int GetNumberOfCards( ) => _currentHand.Count;

        public List<Card> SeeCards( ) => _currentHand;

        public bool HasBusted( ) => (_handTotal > 21) ? true : false;

        public void ClearHand( )
        {
            _handTotal = 0;
            _currentHand.Clear();
        }

        private void AddCardValues( )
        {
            _handTotal = 0;
            int aceCount = 0;
            foreach (Card item in _currentHand)
            {
                switch (item.GetCardValue())
                {
                    case CardValue.Ace:
                        _handTotal += 11;
                        aceCount++;
                        break;
                    case CardValue.Two:
                        _handTotal += 2;
                        break;
                    case CardValue.Three:
                        _handTotal += 3;
                        break;
                    case CardValue.Four:
                        _handTotal += 4;
                        break;
                    case CardValue.Five:
                        _handTotal += 5;
                        break;
                    case CardValue.Six:
                        _handTotal += 6;
                        break;
                    case CardValue.Seven:
                        _handTotal += 7;
                        break;
                    case CardValue.Eight:
                        _handTotal += 8;
                        break;
                    case CardValue.Nine:
                        _handTotal += 9;
                        break;
                    case CardValue.Ten:
                        _handTotal += 10;
                        break;
                    case CardValue.Jack:
                        _handTotal += 10;
                        break;
                    case CardValue.Queen:
                        _handTotal += 10;
                        break;
                    case CardValue.King:
                        _handTotal += 10;
                        break;
                }
            }
            for (int i = 0; i < aceCount; i++)
            {
                if (_handTotal > 21)
                {
                    _handTotal -= 10;
                }
            }
        }

        public void AddCard( Card NewCard )
        {
            _currentHand.Add( NewCard );
            AddCardValues();
        }

        public Card GetCard( )
        {
            foreach (Card card in _currentHand)
            {
                if (!card.UsedValue)
                {
                    card.SetUsedValue( true );
                    return card;
                }
            }

            _currentHand[0].SetUsedValue( true );
            return _currentHand[0];
        }
    }
}