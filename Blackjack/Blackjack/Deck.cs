using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Deck
    {
        Queue<Cards> _cards { get; set; }

        public Deck()
        {
            for (int i = 0; i < 13; i++)
            {
               if(i > 10 || i != 1)
                {

                }
            }
        }
    }
}
