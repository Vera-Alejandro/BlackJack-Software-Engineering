using BlackjackGame;
using System;
using System.Collections.Generic;
using System.Linq;
using SQLite.Storage;

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
        private List<GameData> _gameData { get; set; }

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
            _gameData = new List<GameData>();
            _deck.Shuffle();
        }

        public GameInstance(int playerCount)
        {
            _deck = new Deck();
            _dealerHand = new Hand();
            _players = new List<Hand>();
            _gameData = new List<GameData>();
            _deck.Shuffle();
            for (int x = 0; x < playerCount; x++)
            {
                AddPlayer();
            }
        }

        public void AddPlayer()
        {
            _players.Add(new Hand());
            _splitHands.Add(new Hand());
            _gameData.Add(new GameData());
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
            _gameData[playerNumber - 1].SetMoneyLeftOver(_players[playerNumber - 1].GetTotal());
            return _players[playerNumber - 1]; //indexing starts at 0 normally but "player 1" is more intuitive so I mean....
        }

        public Hand GetSplitHand(int playerNumber)
            => _splitHands[playerNumber - 1]; //indexing starts at 0 normally but "player 1" is more intuitive so I mean....

        public void SetPlayerSplit(int playerNumber) => _hasSplit[playerNumber - 1] = true;

        public bool HasSplit(int playerNumber) => _hasSplit[playerNumber - 1];

        public Hand GetDealerHand() => _dealerHand;

        public Deck GetDeck() => _deck;

        public double GetCash(int playerNumber) => _playerCash[playerNumber - 1];

        public void SetCash(int playerNumber, double cash) => _playerCash[playerNumber - 1] = cash;

        public bool HasBusted(int playerNumber) => (_players[playerNumber - 1].GetTotal() < 22) ? false : true;

        public void SetInsuranceAvailaible(bool insurance) => _insuranceAvailiable = insurance;

        public bool GetInsuranceAvailaible() => _insuranceAvailiable;

        public void SetInsuranceWin(int playerNumber, bool insurance) => _insuranceWin[playerNumber - 1] = insurance;

        public bool GetInsuranceWin(int playerNumber) => _insuranceWin[playerNumber - 1];

        public void SetInsuranceBet(int playerNumber, double money) => _insuranceBets[playerNumber - 1] = money;

        public void SetPlayerResult(int playerNumber, GameResult result) => _playerResults[playerNumber - 1] = result;

        public void SetSplitResult(int playerNumber, GameResult result) => _splitResults[playerNumber - 1] = result;

        public double GetBet(int playerNumber) => _playerBets[playerNumber - 1];

        public double GetInsuranceBet(int playerNumber) => _insuranceBets[playerNumber - 1];

        public GameData GetGameData(int playerNumber) => _gameData[playerNumber - 1];

        public void SetBet(int playerNumber, double money)
        {
            _playerBets[playerNumber - 1] = money;
            _gameData[playerNumber - 1].MoneyBet = Convert.ToInt32(money);
        }

        public double GetPayout(int playerNumber)
        {
            double result = 0;
            const int LOSS_AMT = 0;
            const int WIN_RATIO = 2;
            const int STANDOFF_RATIO = 1;
            const double BLACKJACK_RATIO = 3.5;
            const int INSURANCE_RATIO = 2;

            //Insurance
            if (_insuranceWin[playerNumber - 1])
            {
                result += (_insuranceBets[playerNumber - 1] * INSURANCE_RATIO);
            }

            //split
            if (HasSplit(playerNumber))
            {
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
                _gameData[playerNumber - 1].SetMoneyLost(_gameData[playerNumber - 1].MoneyBet * -1);
            }

            else if (_playerResults[playerNumber - 1] == GameResult.Win)
            {
                result += (_playerBets[playerNumber - 1] * WIN_RATIO);
                _gameData[playerNumber - 1].SetMoneyWon(_gameData[playerNumber - 1].MoneyBet);
            }

            else if (_playerResults[playerNumber - 1] == GameResult.Standoff)
            {
                result += (_playerBets[playerNumber - 1] * STANDOFF_RATIO);
            }
            else
            {
                result += (_playerBets[playerNumber - 1] * BLACKJACK_RATIO);
                _gameData[playerNumber - 1].SetMoneyLost(
                    Convert.ToInt32(
                        (_gameData[playerNumber - 1].MoneyBet * BLACKJACK_RATIO) - _gameData[playerNumber -1].MoneyBet
                    ));
            }

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
