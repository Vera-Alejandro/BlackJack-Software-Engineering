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
        private List<int> _playerResults; //0 = tie, 1 = loss, 2 = win
        private List<int> _playerBets;

        public GameInstance()
        {
            _deck = new Deck();
            _dealerHand = new Hand();
            _players = new List<Hand>();
            _playerResults = new List<int>();
            _playerBets = new List<int>();
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
            _playerResults.Add(0);
            _playerBets.Add(0);
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

        public void SetBet(int playerNumber, int money)
        {
            _playerBets[playerNumber - 1] = money;
        }

        public void SetPlayerResult(int playerNumber, int result)
        {
            _playerResults[playerNumber - 1] = result;
        }

        public int GetBet(int playerNumber)
        {
            return _playerBets[playerNumber - 1];
        }

        public int GetPayout(int playerNumber)
        {
            if(_playerResults[playerNumber -1 ] == 1)
            {
                return (_playerBets[playerNumber - 1] * -1);
            }

            else if(_playerResults[playerNumber - 1] == 2)
            {
                return (_playerBets[playerNumber - 1]);
            }

            else
            {
                return 0;
            }
        }


        public void ResetGame()
        {
            
            foreach(Hand player in _players)
            {
                player.ClearHand();
            }
            _dealerHand.ClearHand();

            for(int i = 0; i < _playerResults.Count(); i++)
            {
                _playerResults[i] = 0;
            }

            for (int i = 0; i < _playerBets.Count(); i++)
            {
                _playerBets[i] = 0;
            }

        }

    }
}
