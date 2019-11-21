using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Storage
{
    [Serializable]
    public class GameData
    {
        public int MoneyBet { get; private set; }
        private int _moneyWon { get; set; }
        private int _moneyLost { get; set; }
        private int _moneyLeftOver { get; set; }
        public int MostMoneymade { get; private set; }
        public int MostMoneyLost { get; private set; }

        public GameData()
        {
            MoneyBet = 0;
            _moneyWon = 0;
            _moneyLost = 0;
            _moneyLeftOver = 0;
            MostMoneyLost = 0;
            MostMoneymade = 0;
        }

        public GameData(int MoneyBet, int MoneyWon, int MoneyLost, int MoneyLeftOver)
        {
            this.MoneyBet = MoneyBet;
            _moneyWon = MoneyWon;
            _moneyLost = MoneyLost;
            _moneyLeftOver = MoneyLeftOver;

            if(_moneyWon > MostMoneymade)
            {
                MostMoneymade = _moneyWon;
            }

            if(_moneyLost > MostMoneyLost)
            {
                MostMoneyLost = _moneyLost;
            }
        }

        public int GetMoneyLeftOver()
        {
            return _moneyLeftOver;
        }

        public int GetMoneyBet()
        {
            return MoneyBet;
        }

        public int GetMoneyWon()
        {
            return _moneyWon;
        }

        public int GetMoneyLost()
        {
            return _moneyLost;
        }
    }
}
