using BlackjackGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class GameInstance
    {
        private Deck _deck;
        private Hand _dealerHand;
        private List<Hand> _players;

        public GameInstance()
        {
            _deck = new Deck();
            _dealerHand = new Hand();
            _players = new List<Hand>();
            _deck.Shuffle();
        }

        public GameInstance(int playerCount)
        {
            _deck = new Deck();
            _dealerHand = new Hand();
            _players = new List<Hand>();
            _deck.Shuffle();
            for (int x = 0; x < playerCount; x++)
            {
                AddPlayer();
            }
        }

        public void AddPlayer()
        {
            Hand playerHand = new Hand();
            _players.Add(playerHand);
        }

        public Hand GetPlayerHand(int playerNumber)
        {
            return _players[playerNumber - 1]; //indexing starts at 0 normally but player 1 is more intuitive so I mean....
        }

        public Hand GetDealerHand()
        {
            return _dealerHand;
        }

        public Deck GetDeck()
        {
            return _deck;
        }
            
        public bool HasBusted(int playerNumber)
        {
            if (_players[playerNumber - 1].GetTotal() < 22)
                return false;
            else
                return true;
        }

        public void ResetGame()
        {
            int i = 0;
            foreach(Hand player in _players)
            {
                player.ClearHand();
            }
            _dealerHand.ClearHand();

        }

    }
}
