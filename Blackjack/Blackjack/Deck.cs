﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlackjackGame.Card;

namespace BlackjackGame
{
    public class Deck
    {
        List<Card> _cards { get; set; }

        public Deck()
        {
            _cards = new List<Card>();

            //create deck
            foreach (SuiteType suit in (SuiteType[])Enum.GetValues(typeof(SuiteType)))
            {
                foreach (CardValue value in (CardValue[])Enum.GetValues(typeof(CardValue)))
                {
                    Card newCard = new Card(value, suit);
                    _cards.Add(newCard);
                }
            }
        }

        public void Shuffle()
        {
            Card[] temp = _cards.ToArray();
            Random rnd = new Random();

            _cards.Clear();

            foreach (Card value in temp.OrderBy(x => rnd.Next()))
            {
                _cards.Add(value);
            }
        }

        public Card GetCard()
        {
            foreach (Card card in _cards)
            {
                if(!card.GetUsedValue())
                {
                    card.SetUsedValue(true);
                    return card;
                }
            }

            Shuffle();

            _cards[0].SetUsedValue(true);
            return _cards[0];
        }
    }
}
