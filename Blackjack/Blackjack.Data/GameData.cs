namespace Blackjack.Data
{
    public class GameData
    {
        public int MoneyBet { get; set; }
        private int _moneyWon { get; set; }
        private int _moneyLost { get; set; }
        private int _moneyLeftOver { get; set; }
        public int MostMoneyMade { get; internal set; }
        public int MostMoneyLost { get; internal set; }

        public GameData( )
        {
            MoneyBet = 0;
            _moneyWon = 0;
            _moneyLost = 0;
            _moneyLeftOver = 0;
            MostMoneyLost = 0;
            MostMoneyMade = 0;
        }

        public GameData( int MoneyBet, int MoneyWon, int MoneyLost, int MoneyLeftOver )
        {
            this.MoneyBet = MoneyBet;
            _moneyWon = MoneyWon;
            _moneyLost = MoneyLost;
            _moneyLeftOver = MoneyLeftOver;

            if (_moneyWon > MostMoneyMade) { MostMoneyMade = _moneyWon; }

            if (_moneyLost < MostMoneyLost) { MostMoneyLost = _moneyLost; }
        }

        public void SetMoneyWon( int Winnings )
        {
            _moneyWon = Winnings;
            MostMoneyMade = (_moneyWon > MostMoneyMade) ? _moneyWon : MostMoneyMade;

        }

        public void SetMoneyLost( int CashLost )
        {
            _moneyLost = CashLost;
            MostMoneyLost = (_moneyLost < MostMoneyLost) ? _moneyLost : MostMoneyLost;
        }

        public int SetMoneyLeftOver( int LeftOver ) => _moneyLeftOver = LeftOver;

        public int GetMoneyLeftOver( ) => _moneyLeftOver;

        public int GetMoneyWon( ) => _moneyWon;

        public int GetMoneyLost( ) => _moneyLost;
    }
}
