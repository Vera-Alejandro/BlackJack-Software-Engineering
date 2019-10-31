using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackGame;

namespace Blackjack
{
    public class Hand
    {
        private int _handTotal { get; set; }
        private List<Card> _currentHand { get; set; }

        public Hand()
        {
            _currentHand = new List<Card>();
            _handTotal = 0;
        }

        public List<Card> SeeCards()
        {
            return _currentHand;
        }

        public int GetTotal()
        {
            return _handTotal;
        }
        
        public void ClearHand()
        {
            _handTotal = 0;
            _currentHand.Clear();
        }

        public void AddCard(Card NewCard)
        {
            _currentHand.Add(NewCard);

            switch (NewCard.GetCardValue())
            {
                case Card.CardValue.Ace:
                    if(_handTotal < 11)
                    {
                        _handTotal += 11;
                    }
                    else
                    {
                        _handTotal += 1;
                    }
                    break;
                case Card.CardValue.Two:
                    _handTotal += 2;
                    break;
                case Card.CardValue.Three:
                    _handTotal += 3;
                    break;
                case Card.CardValue.Four:
                    _handTotal += 4;
                    break;
                case Card.CardValue.Five:
                    _handTotal += 5;
                    break;
                case Card.CardValue.Six:
                    _handTotal += 6;
                    break;
                case Card.CardValue.Seven:
                    _handTotal += 7;
                    break;
                case Card.CardValue.Eight:
                    _handTotal += 8;
                    break;
                case Card.CardValue.Nine:
                    _handTotal += 9;
                    break;
                case Card.CardValue.Ten:
                    _handTotal += 10;
                    break;
                case Card.CardValue.Jack:
                    _handTotal += 10;
                    break;
                case Card.CardValue.Queen:
                    _handTotal += 10;
                    break;
                case Card.CardValue.King:
                    _handTotal += 10;
                    break;
            }
        }

        public Card GetCard()
        {
            foreach (Card card in _currentHand)
            {
                if (!card.GetUsedValue())
                {
                    card.SetUsedValue(true);
                    return card;
                }
            }

            _currentHand[0].SetUsedValue(true);
            return _currentHand[0];
        }
    }
}
