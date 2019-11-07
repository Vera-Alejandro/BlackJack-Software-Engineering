using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Storage
{
    [Serializable]
    public class DataStorage
    {
        private int _moneyBet { get; set; }
        private int _moneyWon { get; set; }
        private int _moneyLost { get; set; }
        private int _moneyleftover { get; set; }
        private int _mostMoneymade { get; set; }
        private int _mostMoneyLost { get; set; }

        public DataStorage()
        {
            _moneyBet = 0;
            _moneyWon = 0;
            _moneyLost = 0;
            _moneyleftover = 0;
            _mostMoneyLost = 0;
            _mostMoneymade = 0;
        }

        public DataStorage(int MoneyBet, int MoneyWon, int MoneyLost, int MoneyLeftOver)
        {
            _moneyBet = MoneyBet;
            _moneyWon = MoneyWon;
            _moneyLost = MoneyLost;
            _moneyleftover = MoneyLeftOver;

            if(_moneyWon > _mostMoneymade)
            {
                _mostMoneymade = _moneyWon;
            }

            if(_moneyLost > _mostMoneyLost)
            {
                _mostMoneyLost = _moneyLost;
            }
        }
    }
}
