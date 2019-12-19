using BlackjackGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class GameInstance
    {
        private Deck _deck;
        private Hand _dealerHand;
        private List<Hand> _players;
        private List<Hand> _splitHands;
        private List<GameResult> _splitResults;
        private List<GameResult> _playerResults;
        private List<double> _playerBets;
        private List<double> _insuranceBets;
        private bool _insuranceAvailiable;
        private List<bool> _insuranceWin;
        private List<bool> _hasSplit;
        private List<double> _playerCash;

        const double DEFAULT_CASH = 500;

        public GameInstance()
        {
            _insuranceAvailiable = false;
            _insuranceWin = new List<bool>();
            _hasSplit = new List<bool>();
            _deck = new Deck();
            _dealerHand = new Hand();
            _players = new List<Hand>();
            _splitHands = new List<Hand>();
            _playerResults = new List<GameResult>();
            _splitResults = new List<GameResult>();
            _playerBets = new List<double>();
            _insuranceBets = new List<double>();
            _playerCash = new List<double>();
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
            Hand splitHand = new Hand();
            _players.Add(playerHand);
            _splitHands.Add(splitHand);
            _hasSplit.Add(false);
            _playerResults.Add(0);
            _splitResults.Add(0);
            _playerBets.Add(0);
            _insuranceBets.Add(0);
            _insuranceWin.Add(false);
            _playerCash.Add(DEFAULT_CASH);
        }

        public Hand GetPlayerHand(int playerNumber)
        {
            return _players[playerNumber - 1]; //indexing starts at 0 normally but "player 1" is more intuitive so I mean....
        }

        public Hand GetSplitHand(int playerNumber)
        {
            return _splitHands[playerNumber - 1]; //indexing starts at 0 normally but "player 1" is more intuitive so I mean....
        }

        public void SetPlayerSplit(int playerNumber)
        {
            _hasSplit[playerNumber - 1] = true;
        }

        public bool HasSplit(int playerNumber)
        {
            return _hasSplit[playerNumber - 1];
        }

        public Hand GetDealerHand()
        {
            return _dealerHand;
        }

        public Deck GetDeck()
        {
            return _deck;
        }

        public double GetCash(int playerNumber)
        {
            return _playerCash[playerNumber - 1];
        }

        public void SetCash(int playerNumber, double cash)
        {
            _playerCash[playerNumber - 1] = cash;
        }

        public bool HasBusted(int playerNumber)
        {
            if (_players[playerNumber - 1].GetTotal() < 22)
                return false;
            else
                return true;
        }

        public void SetInsuranceAvailaible(bool insurance)
        {
            _insuranceAvailiable = insurance;
        }

        public bool GetInsuranceAvailaible()
        {
            return _insuranceAvailiable;
        }

        public void SetInsuranceWin(int playerNumber, bool insurance)
        {
            _insuranceWin[playerNumber - 1] = insurance;
        }

        public bool GetInsuranceWin(int playerNumber)
        {
            return _insuranceWin[playerNumber - 1];
        }

        public void SetBet(int playerNumber, double money)
        {
            _playerBets[playerNumber - 1] = money;
        }

        public void SetInsuranceBet(int playerNumber, double money)
        {
            _insuranceBets[playerNumber - 1] = money;
        }


        public void SetPlayerResult(int playerNumber, GameResult result)
        {
            _playerResults[playerNumber - 1] = result;
        }

        public void SetSplitResult(int playerNumber, GameResult result)
        {
            _splitResults[playerNumber - 1] = result;
        }

        public double GetBet(int playerNumber)
        {
            return _playerBets[playerNumber - 1];
        }

        public double GetInsuranceBet(int playerNumber)
        {
            return _insuranceBets[playerNumber - 1];
        }

        public double GetPayout(int playerNumber)
        {
            double result = 0;
            const int LOSS_AMT = 0;
            const int WIN_RATIO = 2;
            const int STANDOFF_RATIO = 1;
            const double BLACKJACK_RATIO = 3.5;
            const int INSURANCE_RATIO = 2;

            if (_insuranceWin[playerNumber - 1])
            {
                result += (_insuranceBets[playerNumber - 1] * INSURANCE_RATIO);
            }

            if (HasSplit(playerNumber))
            {
                Console.WriteLine("In here yay");
                if (_splitResults[playerNumber - 1] == GameResult.Loss)
                {
                    result += LOSS_AMT;
                }

                else if (_splitResults[playerNumber - 1] == GameResult.Win)
                {
                    result += (_playerBets[playerNumber - 1] * WIN_RATIO);
                }

                else if (_splitResults[playerNumber - 1] == GameResult.Standoff)
                {
                    result += (_playerBets[playerNumber - 1] * STANDOFF_RATIO);
                }
            }


            if (_playerResults[playerNumber - 1] == GameResult.Loss)
            {
                result += LOSS_AMT;
            }

            else if (_playerResults[playerNumber - 1] == GameResult.Win)
            {
                result += (_playerBets[playerNumber - 1] * WIN_RATIO);
            }

            else if (_playerResults[playerNumber - 1] == GameResult.Standoff)
            {
                result += (_playerBets[playerNumber - 1] * STANDOFF_RATIO);
            }
            else
            {
                Console.WriteLine("Returning blackjack payout of " + _playerBets[playerNumber - 1]);
                result += (_playerBets[playerNumber - 1] * BLACKJACK_RATIO);
            }
            Console.WriteLine("Returning total payout of " + result);
            return result;
        }

        public void ResetGame()
        {
            _insuranceAvailiable = false;

            foreach (Hand player in _players)
            {
                player.ClearHand();
            }
            foreach (Hand split in _splitHands)
            {
                split.ClearHand();
            }
            _dealerHand.ClearHand();

            for (int i = 0; i < _playerResults.Count(); i++)
            {
                _playerResults[i] = 0;
            }

            for (int i = 0; i < _splitResults.Count(); i++)
            {
                _splitResults[i] = 0;
            }

            for (int i = 0; i < _playerBets.Count(); i++)
            {
                _playerBets[i] = 0;
            }

            for (int i = 0; i < _insuranceBets.Count(); i++)
            {
                _insuranceBets[i] = 0;
            }

            for (int i = 0; i < _insuranceWin.Count(); i++)
            {
                _insuranceWin[i] = false;
            }

            for (int i = 0; i < _hasSplit.Count(); i++)
            {
                _hasSplit[i] = false;
            }
        }

        public enum GameResult
        {
            Win,
            Loss,
            Standoff,
            PlayerBlackjack
        }

    }
}
