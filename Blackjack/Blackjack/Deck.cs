using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Blackjack.Card;

namespace Blackjack
{
    public class Deck
    {
        Stack<Card> _cards { get; set; }

        public Deck()
        {
            _cards = new Stack<Card>();

            //create deck
            foreach (SuiteType suit in (SuiteType[])Enum.GetValues(typeof(SuiteType)))
            {
                foreach (CardValue value in (CardValue[])Enum.GetValues(typeof(CardValue)))
                {
                    Card newCard = new Card(value, suit);
                    _cards.Push(newCard);
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
                _cards.Push(value);
            }
        }

    }
}
