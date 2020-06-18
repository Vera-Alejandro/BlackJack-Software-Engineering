using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Blackjack;
using System.Globalization;
using System.IO;
using SQLite;

namespace BlackjackGame
{
    public partial class Blackjack : Form
    {
        #region Move Form

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Blackjack_MouseDown(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        ProfileInterface profileForm = new ProfileInterface();
        private string SQLiteFile =
            Path.Combine(
                Directory.GetParent(
                    Directory.GetParent(
                        Directory.GetCurrentDirectory()
                    ).FullName
                ).FullName, 
            "GameData.sqlite3");

        private bool gameStarted = false;
        private bool roundStarted = false;
        private bool restartAvailable = false;
        private bool splitAvailable = false;
        private bool splitHandDone = false;

        private GameInstance thisGame = new GameInstance();

        private List<PictureBox> dealerCardPictures = new List<PictureBox>();
        private List<PictureBox> playerCardPictures = new List<PictureBox>();
        private List<PictureBox> splitCardPictures1 = new List<PictureBox>();
        private List<PictureBox> splitCardPictures2 = new List<PictureBox>();

        public Dictionary<int, string> Players { get; internal set; }
        public string CurrentUser { set { ActiveUser.Text = value; } }


        private double playerCash;
        private int currentPlayer = 0;
        private int numPlayers;

        public Blackjack()
        {
            InitializeComponent();
        }

        #region Form Functions

        private void Blackjack_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            TitleImage.Visible = true;
            InsuranceButton.Visible = false;
            SplitButton.Visible = false;
            SCName.Visible = false;
            SplitCount.Visible = false;
            OnePlayerButton.Visible = true;
            TwoPlayerButton.Visible = true;
            ThreePlayerButton.Visible = true;

            Players = new Dictionary<int, string>();
            Sound jazzSound = new Sound("jazz.mp3");
            jazzSound.Play();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Resize_Click(object sender, EventArgs e)
        {
            WindowState = (WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Blackjack_SizeChanged(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                TitleImage.Location = new Point((Width / 2) - (TitleImage.Width / 2), (Height / 2) - (TitleImage.Height / 2));
                //StartButton.Location = new Point((Width / 2) - (StartButton.Width / 2), (Height / 2) - (StartButton.Height / 2) + ((StartButton.Height / 2) + (TitleImage.Height / 2) + 12));
                OnePlayerButton.Location = new Point((Width / 2) - (OnePlayerButton.Width / 2) - 225, (Height / 2) - (OnePlayerButton.Height / 2) + ((OnePlayerButton.Height / 2) + (TitleImage.Height / 2) + 12));
                TwoPlayerButton.Location = new Point((Width / 2) - (TwoPlayerButton.Width / 2), (Height / 2) - (TwoPlayerButton.Height / 2) + ((TwoPlayerButton.Height / 2) + (TitleImage.Height / 2) + 12));
                ThreePlayerButton.Location = new Point((Width / 2) - (ThreePlayerButton.Width / 2) + 225, (Height / 2) - (ThreePlayerButton.Height / 2) + ((ThreePlayerButton.Height / 2) + (TitleImage.Height / 2) + 12));
            }
            else
            {
                TitleImage.Location = new Point(12, 12);
            }
        }
    
        #endregion

        private void Start_Game(int players)
        {
            #region Relocating Title and Making Game Visible

            TitleImage.Location = new Point(12, 12);
            StartButton.Visible = false;
            OnePlayerButton.Visible = false;
            TwoPlayerButton.Visible = false;
            ThreePlayerButton.Visible = false;

            DealerHand.Visible = true;
            PlayerHand.Visible = true;
            Output.Visible = true;
            BettingPanel.Visible = true;
            ProfileButton.Visible = true;
            SaveButton.Visible = true;
            ResetButton.Visible = true;

            #endregion

            gameStarted = true;
            currentPlayer = 1;
            Output.Text = "Player 1 turn.";

            for (int i = 0; i < players; i++)
            {
                thisGame.AddPlayer(); //add a player to the game
                Players.Add(players + 1, "guest");
            }

            playerCash = thisGame.GetCash(currentPlayer);


            for (int i = 0; i < 10; i++)
            {
                PictureBox card = new PictureBox();
                playerCardPictures.Add(card);
                playerCardPictures[i].Image = null;
                playerCardPictures[i].Location = new Point((0 + (i * 40)), 75);
                playerCardPictures[i].SizeMode = PictureBoxSizeMode.AutoSize;
                PlayerHand.Controls.Add(playerCardPictures[i]);
                playerCardPictures[i].BringToFront();
            }

            for (int i = 0; i < 10; i++)
            {
                PictureBox card = new PictureBox();
                splitCardPictures1.Add(card);
                splitCardPictures1[i].Image = null;
                splitCardPictures1[i].Location = new Point((0 + (i * 40)), 75);
                splitCardPictures1[i].SizeMode = PictureBoxSizeMode.Zoom;
                Size size = new Size(137, 200);
                splitCardPictures1[i].Size = size;
                PlayerHand.Controls.Add(splitCardPictures1[i]);
                //splitCardPictures1[i].BringToFront();
            }

            for (int i = 0; i < 10; i++)
            {
                PictureBox card = new PictureBox();
                splitCardPictures2.Add(card);
                splitCardPictures2[i].Image = null;
                splitCardPictures2[i].Location = new Point((0 + (i * 40)), 200);
                splitCardPictures2[i].SizeMode = PictureBoxSizeMode.Zoom;
                Size size = new Size(137, 200);
                splitCardPictures2[i].Size = size;
                PlayerHand.Controls.Add(splitCardPictures2[i]);
                //splitCardPictures2[i].BringToFront();
            }



            for (int i = 0; i < 10; i++)
            {
                PictureBox card = new PictureBox();
                dealerCardPictures.Add(card);
                dealerCardPictures[i].Image = null;
                dealerCardPictures[i].Location = new Point((0 + (i * 40)), 75);
                dealerCardPictures[i].SizeMode = PictureBoxSizeMode.AutoSize;
                DealerHand.Controls.Add(dealerCardPictures[i]);
                dealerCardPictures[i].BringToFront();
            }

        }

        private void Stay_Click(object sender, EventArgs e)
        {
            this.InsuranceButton.Visible = false;
            this.SplitButton.Visible = false;
            if (thisGame.GetBet(currentPlayer) <= 0)
            {
                Output.Text = "Must bet to play!";
                return;
            }
            if (thisGame.HasSplit(currentPlayer) && !splitHandDone)
            {
                splitHandDone = true;
                Output.Text = "Player " + currentPlayer.ToString() + " chose to stay on hand 1.";
            }
            else
            {
                Output.Text = "Player " + currentPlayer.ToString() + " choose to stay";
                this.Hit.Visible = false;
                this.Stay.Visible = false;
                Computer_Turn();
            }
        }

        private void Hit_Click(object sender, EventArgs e)
        {
            thisGame.SetInsuranceAvailaible(false);
            InsuranceButton.Visible = false;
            SplitButton.Visible = false;
            if (thisGame.GetBet(currentPlayer) <= 0)
            {
                Output.Text = "Must bet to play!";
                return;
            }

            Output.Text = "Player " + currentPlayer.ToString() + " choose to hit.";

            Card hitCard = thisGame.GetDeck().GetCard();
            Hand hand = thisGame.GetPlayerHand(currentPlayer);
            Hand splitHand = thisGame.GetSplitHand(currentPlayer);

            if (!thisGame.HasSplit(currentPlayer))
            {
                hand.AddCard(hitCard);

                DisplayCards(true);
                PlayerCount.Text = hand.GetTotal().ToString();
                if (hand.HasBusted())
                {
                    Output.Text = "Player " + currentPlayer.ToString() + " busted!";
                    this.Hit.Visible = false;
                    this.Stay.Visible = false;
                    Who_Won();
                }
            }
            else if (!splitHandDone)
            {
                hand.AddCard(hitCard);
                DisplayCards(true);
                PlayerCount.Text = hand.GetTotal().ToString();
                if (hand.HasBusted())
                {
                    Output.Text = "Hand 1 busted!";
                    splitHandDone = true;
                }
            }
            else
            {
                splitHand.AddCard(hitCard);
                SplitCount.Text = splitHand.GetTotal().ToString();
                DisplayCards(true);
                if (splitHand.HasBusted())
                {
                    Output.Text = "Hand 2 busted!";
                    this.Hit.Visible = false;
                    this.Stay.Visible = false;
                    if (hand.HasBusted())
                    {
                        Who_Won();
                    }
                    else
                    {
                        Computer_Turn();
                    }

                }

            }
        }

        private void Computer_Turn()
        {
            int dealerStayValue = 17;
            Hand dealerHand = thisGame.GetDealerHand();

            if (dealerHand.GetTotal() < dealerStayValue)
            {
                while (dealerHand.GetTotal() < dealerStayValue)
                {
                    Card hitCard = thisGame.GetDeck().GetCard();
                    dealerHand.AddCard(hitCard);
                    DisplayCards(false);
                }
            }

            Who_Won();
        }

        private void Who_Won()
        {
            thisGame.SetInsuranceAvailaible(false);
            Hand dealerHand = thisGame.GetDealerHand();
            Hand playerHand = thisGame.GetPlayerHand(currentPlayer);
            DisplayCards(false);
            Hit.Visible = false;
            Stay.Visible = false;
            InsuranceButton.Visible = false;
            SplitButton.Visible = false;
            if (thisGame.HasSplit(currentPlayer))
            {
                Hand splitHand = thisGame.GetSplitHand(currentPlayer);
                string hand1Result;
                string hand2Result;
                if (playerHand.HasBusted())
                {
                    thisGame.SetPlayerResult(currentPlayer, GameInstance.GameResult.Loss);
                    hand1Result = "Loss";
                }
                else
                {
                    if (playerHand.GetTotal() == dealerHand.GetTotal())
                    {
                        thisGame.SetPlayerResult(currentPlayer, GameInstance.GameResult.Standoff);
                        hand1Result = "Standoff";
                    }
                    else if ((playerHand.GetTotal() < dealerHand.GetTotal()) && !dealerHand.HasBusted())
                    {
                        thisGame.SetPlayerResult(currentPlayer, GameInstance.GameResult.Loss);
                        hand1Result = "Loss";
                    }
                    else
                    {
                        thisGame.SetPlayerResult(currentPlayer, GameInstance.GameResult.Win);
                        hand1Result = "Win";
                    }
                }
                if (splitHand.HasBusted())
                {
                    thisGame.SetSplitResult(currentPlayer, GameInstance.GameResult.Loss);
                    hand2Result = "Loss";
                }
                else
                {
                    if (splitHand.GetTotal() == dealerHand.GetTotal())
                    {
                        thisGame.SetSplitResult(currentPlayer, GameInstance.GameResult.Standoff);
                        hand2Result = "Standoff";
                    }
                    else if ((splitHand.GetTotal() < dealerHand.GetTotal()) && !dealerHand.HasBusted())
                    {
                        thisGame.SetSplitResult(currentPlayer, GameInstance.GameResult.Loss);
                        hand2Result = "Loss";
                    }
                    else
                    {
                        thisGame.SetSplitResult(currentPlayer, GameInstance.GameResult.Win);
                        hand2Result = "Win";
                    }
                }
                Output.Text = ("Hand 1: " + hand1Result + "    Hand 2: " + hand2Result);
            }

            else if (playerHand.HasBusted())
            {
                Output.Text = ("Player " + currentPlayer.ToString() + " Busted, Computer Wins.");
                thisGame.SetPlayerResult(currentPlayer, GameInstance.GameResult.Loss);

            }
            else if (dealerHand.HasBusted())
            {
                Output.Text = ("Dealer Busted, Player " + currentPlayer.ToString() + " Wins.");
                thisGame.SetPlayerResult(currentPlayer, GameInstance.GameResult.Win);

            }
            else if (playerHand.GetTotal() == 21 && dealerHand.GetTotal() != 21 && playerHand.GetNumberOfCards() == 2)
            {
                Output.Text = ("Player " + currentPlayer.ToString() + " got a natural blackjack!");
                thisGame.SetPlayerResult(currentPlayer, GameInstance.GameResult.PlayerBlackjack);

            }
            else if (playerHand.GetTotal() > dealerHand.GetTotal())
            {
                Output.Text = ("Player " + currentPlayer.ToString() + " Wins.");
                thisGame.SetPlayerResult(currentPlayer, GameInstance.GameResult.Win);

            }
            else if (playerHand.GetTotal() == dealerHand.GetTotal())
            {
                Output.Text = ("Player " + currentPlayer.ToString() + " and dealer tied. No payouts awarded.");
                thisGame.SetPlayerResult(currentPlayer, GameInstance.GameResult.Standoff);
            }
            else
            {
                Output.Text = ("Computer Wins.");
                thisGame.SetPlayerResult(currentPlayer, GameInstance.GameResult.Loss);
            }

            if (thisGame.GetInsuranceWin(currentPlayer))
            {
                Output.Text += "    Insurance bet won!";
            }

            playerCash += thisGame.GetPayout(1);
            thisGame.SetCash(currentPlayer, playerCash);
            PlayerCash.Text = playerCash.ToString("C", CultureInfo.CurrentCulture);
            restartAvailable = true;
        }

        private void BetThousand_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 1000;
            CreateBet(BET_AMT, currentPlayer);
        }

        private void BetAll_Click(object sender, EventArgs e)
        {
            if (roundStarted)
            {
                if (thisGame.GetInsuranceAvailaible())
                {
                    Output.Text = "Must be half or less of original bet.";
                }
                else
                {
                    Output.Text = "Cards already dealt!";
                }
            }
            else if (playerCash <= 0)
            {
                Output.Text = "No money to bet!";
            }
            else
            {
                thisGame.SetBet(currentPlayer, playerCash);
                playerCash = 0;
                thisGame.SetCash(currentPlayer, playerCash);
                Output.Text = "Player " + currentPlayer.ToString() + " went all in!";
                PlayerCash.Text = playerCash.ToString("C", CultureInfo.CurrentCulture);
                StartRound();
            }
        }

        private void BetFiveHundred_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 500;
            CreateBet(BET_AMT, currentPlayer);
        }

        private void BetTwoFifty_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 250;
            CreateBet(BET_AMT, currentPlayer);
        }

        private void BetHundred_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 100;
            CreateBet(BET_AMT, currentPlayer);
        }

        private void BetFifty_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 50;
            CreateBet(BET_AMT, currentPlayer);
        }

        private void BetTwentyFive_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 25;
            CreateBet(BET_AMT, currentPlayer);
        }

        private void BetTen_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 10;
            CreateBet(BET_AMT, currentPlayer);
        }

        private void BetFive_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 5;
            CreateBet(BET_AMT, currentPlayer);
        }

        private void BetOne_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 1;
            CreateBet(BET_AMT, currentPlayer);
        }

        private void CreateBet(double BET_AMT, int player)
        {
            if (roundStarted)
            {
                if (thisGame.GetInsuranceAvailaible())
                {
                    if ((thisGame.GetBet(player) / 2) >= BET_AMT)
                    {
                        thisGame.SetInsuranceBet(player, BET_AMT);
                        thisGame.SetInsuranceAvailaible(false);
                        playerCash = playerCash - thisGame.GetInsuranceBet(player);
                        thisGame.SetCash(currentPlayer, playerCash);
                        PlayerCash.Text = playerCash.ToString("C", CultureInfo.CurrentCulture);
                        Hit.Visible = true;
                        Stay.Visible = true;
                        if (splitAvailable)
                            SplitButton.Visible = true;
                        Output.Text = "Player " + currentPlayer.ToString() + " bet $" + BET_AMT.ToString() + ".00 insurance.";
                        if (thisGame.GetDealerHand().GetTotal() == 21)
                        {
                            thisGame.SetInsuranceWin(player, true);
                            if (!thisGame.HasSplit(currentPlayer))
                            {
                                Output.Text = "Insurance bet won!";
                                Who_Won();
                            }

                        }
                        else
                        {
                            Output.Text = "Dealer did not have blackjack. Side bet lost.";
                        }
                    }
                    else Output.Text = "Must be half or less of original bet.";
                }
                else
                {
                    Output.Text = "Cards already dealt!";
                }
            }

            else if (CanBet(BET_AMT))
            {
                playerCash = playerCash - BET_AMT;
                thisGame.SetCash(currentPlayer, playerCash);
                PlayerCash.Text = playerCash.ToString("C", CultureInfo.CurrentCulture);
                thisGame.SetBet(currentPlayer, BET_AMT);
                Output.Text = "Player " + currentPlayer.ToString() + " bet:  $" + thisGame.GetBet(player).ToString() + ".";
                StartRound();
            }
            else
                Output.Text = "Not enough money to bet!";
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            if (profileForm.IsDisposed)
                profileForm = new ProfileInterface();
            profileForm.Show();

        }

        private void DisplayCards(bool dealerFaceDown)
        {

            Hand p1Hand = thisGame.GetPlayerHand(currentPlayer);
            Hand dealerHand = thisGame.GetDealerHand();

            List<Card> dealerCards = dealerHand.SeeCards();
            List<Card> p1Cards = p1Hand.SeeCards();

            int downValue = 0;
            int i = 0;
            foreach (Card card in dealerCards)
            {
                //PictureBox cardPicture = new PictureBox();
                if (dealerFaceDown)
                {
                    if (i == 0)
                    {
                        dealerCardPictures[i].Image = card.GetImage();
                        if (card.GetCardValue() == Card.CardValue.Ace)
                        {
                            thisGame.SetInsuranceAvailaible(true);
                            Console.WriteLine("Insurance availiable!");
                        }
                    }

                    else if (i == 1)
                    {
                        dealerCardPictures[i].Image = card.GetBackImage();

                        switch (card.GetCardValue())
                        {
                            case Card.CardValue.Ace:
                                downValue = 11;
                                break;
                            case Card.CardValue.Two:
                                downValue = 2;
                                break;
                            case Card.CardValue.Three:
                                downValue = 3;
                                break;
                            case Card.CardValue.Four:
                                downValue = 4;
                                break;
                            case Card.CardValue.Five:
                                downValue = 5;
                                break;
                            case Card.CardValue.Six:
                                downValue = 6;
                                break;
                            case Card.CardValue.Seven:
                                downValue = 7;
                                break;
                            case Card.CardValue.Eight:
                                downValue = 8;
                                break;
                            case Card.CardValue.Nine:
                                downValue = 9;
                                break;
                            case Card.CardValue.Ten:
                                downValue = 10;
                                break;
                            case Card.CardValue.Jack:
                                downValue = 10;
                                break;
                            case Card.CardValue.Queen:
                                downValue = 10;
                                break;
                            case Card.CardValue.King:
                                downValue = 10;
                                break;
                        }
                    }
                }
                else
                {
                    dealerCardPictures[i].Image = card.GetImage();
                }

                dealerCardPictures[i].BringToFront();

                i++;

            }

            i = 0;
            if (!thisGame.HasSplit(currentPlayer))
            {
                foreach (Card card in p1Cards)
                {
                    Console.WriteLine("In normal loop");
                    playerCardPictures[i].Image = card.GetImage();
                    playerCardPictures[i].BringToFront();

                    i++;
                }
            }
            else
            {
                List<Card> hand1 = thisGame.GetPlayerHand(currentPlayer).SeeCards();
                List<Card> hand2 = thisGame.GetSplitHand(currentPlayer).SeeCards();
                i = 0;
                foreach (PictureBox cardPic in playerCardPictures)
                {
                    cardPic.Image = null;
                }
                foreach (Card card in hand1)
                {
                    playerCardPictures[i].Image = null;
                    splitCardPictures1[i].Image = card.GetImage();
                    splitCardPictures1[i].BringToFront();
                    i++;
                }
                i = 0;
                foreach (Card card in hand2)
                {
                    splitCardPictures2[i].Image = card.GetImage();
                    splitCardPictures2[i].BringToFront();
                    i++;
                }
                SplitCount.Text = thisGame.GetSplitHand(currentPlayer).GetTotal().ToString();
                PlayerCount.Text = p1Hand.GetTotal().ToString();
            }


            if (dealerHand.GetTotal() == 21 && !thisGame.GetInsuranceAvailaible())
            {
                dealerCardPictures[1].Image = dealerCards[1].GetImage();
                DealerCount.Text = dealerHand.GetTotal().ToString();
            }
            else
            {
                int dealerDisplayTotal = (dealerHand.GetTotal() - downValue);
                DealerCount.Text = dealerDisplayTotal.ToString();
            }

            PlayerCount.Text = p1Hand.GetTotal().ToString();

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Output.Text = "";
            if (!restartAvailable)
            {
                Output.Text = "Restart not available.";
                return;
            }
            else
            {
                splitAvailable = false;
                bool cantPlay = true;
                for (int i = 1; i <= numPlayers; i++)
                {
                    if (thisGame.GetCash(i) > 0)
                        cantPlay = false;
                }
                if (cantPlay)
                {
                    Output.Text = "All players out of money.";
                }
                else
                {
                    this.Hit.Visible = true;
                    this.Stay.Visible = true;
                    thisGame.ResetGame();
                    currentPlayer++;
                    if (currentPlayer > numPlayers)
                        currentPlayer = 1;

                    playerCash = thisGame.GetCash(currentPlayer);
                    PlayerCash.Text = playerCash.ToString("C", CultureInfo.CurrentCulture);
                    if (playerCash <= 0)
                    {
                        ResetButton_Click(sender, e);
                    }
                    else
                    {
                        foreach (PictureBox cardPic in dealerCardPictures)
                        {
                            cardPic.Image = null;
                        }
                        foreach (PictureBox cardPic in playerCardPictures)
                        {
                            cardPic.Image = null;
                        }
                        foreach (PictureBox cardPic in splitCardPictures1)
                        {
                            cardPic.Image = null;
                        }
                        foreach (PictureBox cardPic in splitCardPictures2)
                        {
                            cardPic.Image = null;
                        }
                        restartAvailable = false;
                        roundStarted = false;
                        splitHandDone = false;
                        SplitCount.Visible = false;
                        SCName.Visible = false;
                        PCName.Text = "Player Count";
                        PlayerCount.Text = 0.ToString();
                        DealerCount.Text = 0.ToString();
                        int prevPlayer = currentPlayer - 1;
                        if (prevPlayer < 1)
                            prevPlayer = numPlayers;
                        if (thisGame.GetCash(prevPlayer) <= 0)
                            Output.Text += "Player " + prevPlayer.ToString() + " has no money! ";
                        Output.Text += "Player " + currentPlayer.ToString() + " turn.";
                    }
                }

            }

        }

        private bool CanBet(double bet)
        {
            return (bet <= playerCash);
        }

        private void StartRound()
        {
            roundStarted = true;
            //deal first card out
            Deck dealingDeck = thisGame.GetDeck();
            Hand dealerHand = thisGame.GetDealerHand();
            Hand playerHand = thisGame.GetPlayerHand(currentPlayer);

            List<Card> dealerCards = dealerHand.SeeCards();
            List<Card> playerCards = playerHand.SeeCards();

            Card testcard1 = new Card(Card.CardValue.Ace, Card.SuiteType.Clubs);
            Card testcard2 = new Card(Card.CardValue.Four, Card.SuiteType.Clubs);
            Card testcard3 = new Card(Card.CardValue.Five, Card.SuiteType.Hearts);
            Card testcard4 = new Card(Card.CardValue.Five, Card.SuiteType.Spades);

            dealerHand.AddCard(dealingDeck.GetCard());
            dealerHand.AddCard(dealingDeck.GetCard());

            playerHand.AddCard(dealingDeck.GetCard());
            playerHand.AddCard(dealingDeck.GetCard());


            Card p1Card = playerHand.SeeCards()[0];
            Card p2Card = playerHand.SeeCards()[1];

            DisplayCards(true);
            if (thisGame.GetInsuranceAvailaible())
            {
                InsuranceButton.Visible = true;
            }

            if (p1Card.GetCardValue() == p2Card.GetCardValue())
            {
                Console.WriteLine("Making split available");
                if (p1Card.GetCardValue() == Card.CardValue.Five)
                    Console.WriteLine("Five");
                SplitButton.Visible = true;
                splitAvailable = true;
            }

            if ((dealerHand.GetTotal() == 21 || playerHand.GetTotal() == 21) && !thisGame.GetInsuranceAvailaible())
            {
                this.Hit.Visible = false;
                this.Stay.Visible = false;
                this.InsuranceButton.Visible = false;
                this.SplitButton.Visible = false;
                Who_Won();
            }
        }

        private void InsuranceButton_Click(object sender, EventArgs e)
        {
            const double MIN_CASH = 1;
            if (playerCash <= MIN_CASH)
            {
                Output.Text = "Not enough money to bet insurance.";
            }
            else
            {
                Hit.Visible = false;
                Stay.Visible = false;
                SplitButton.Visible = false;
                InsuranceButton.Visible = false;
                Output.Text = "Please select insurance bet.";
            }
        }

        private void SplitButton_Click(object sender, EventArgs e)
        {
            if (CanBet(thisGame.GetBet(currentPlayer)))
            {
                SCName.Visible = true;
                PCName.Text = "Hand 1 Count";
                SplitCount.Visible = true;
                Output.Text = "Player " + currentPlayer.ToString() + " chose to split hand.";

                playerCash = playerCash - thisGame.GetBet(currentPlayer);
                thisGame.SetCash(currentPlayer, playerCash);
                PlayerCash.Text = playerCash.ToString("C", CultureInfo.CurrentCulture);

                thisGame.SetPlayerSplit(currentPlayer);
                SplitButton.Visible = false;
                Card p1Card = thisGame.GetPlayerHand(currentPlayer).SeeCards()[0];
                Card p2Card = thisGame.GetPlayerHand(currentPlayer).SeeCards()[1];
                thisGame.GetPlayerHand(currentPlayer).ClearHand();
                thisGame.GetPlayerHand(currentPlayer).AddCard(p1Card);
                thisGame.GetSplitHand(currentPlayer).AddCard(p2Card);
                DisplayCards(true);
            }
            else
            {
                Output.Text = "Not enough money to split!";
            }

        }

        private void OnePlayerButton_Click(object sender, EventArgs e)
        {
            numPlayers = 1;
            Start_Game(1);
        }

        private void TwoPlayerButton_Click(object sender, EventArgs e)
        {
            numPlayers = 2;
            Start_Game(2);
        }

        private void ThreePlayerButton_Click(object sender, EventArgs e)
        {
            numPlayers = 3;
            Start_Game(3);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Database StorageDB = new Database(SQLiteFile);
            StorageDB.Connect();

            //StorageDB.SaveGameState(thisGame.GetGameData(currentPlayer), )

            StorageDB.Disconnect();
        }

        private void PlayerCash_TextChanged(object sender, EventArgs e)
        {

        }
    }
}