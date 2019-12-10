using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Blackjack;
using System.Globalization;
using System.IO;

namespace BlackjackGame
{
    public partial class Blackjack : Form
    {

		ProfileInterface profileForm = new ProfileInterface();

		#region Move Form

		public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private const double START_CASH = 500.00;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Blackjack_MouseDown(Object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private bool gameStarted = false;
        private bool roundStarted = false;
        private bool restartAvailable = false;
        private bool splitHandDone = false;

        private string RunningPath = AppDomain.CurrentDomain.BaseDirectory;

        private GameInstance thisGame = new GameInstance();

        private List<PictureBox> dealerCardPictures = new List<PictureBox>();
        private List<PictureBox> playerCardPictures = new List<PictureBox>();
        private List<PictureBox> splitCardPictures1 = new List<PictureBox>();
        private List<PictureBox> splitCardPictures2 = new List<PictureBox>();

        private double playerCash = START_CASH;

        public Blackjack()
        {
            InitializeComponent();
        }

        private void Blackjack_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            TitleImage.Visible = true;
            StartButton.Visible = true;
            InsuranceButton.Visible = false;
            SplitButton.Visible = false;
            SCName.Visible = false;
            SplitCount.Visible = false;

            Sound jazzSound = new Sound("jazz.mp3");
            jazzSound.Play();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Resize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Blackjack_SizeChanged(object sender, EventArgs e)
        {
            if (gameStarted == false)
            {
                TitleImage.Location = new Point((Width / 2) - (TitleImage.Width / 2), (Height / 2) - (TitleImage.Height / 2));
                StartButton.Location = new Point((Width / 2) - (StartButton.Width / 2), (Height / 2) - (StartButton.Height / 2) + ((StartButton.Height / 2) + (TitleImage.Height / 2) + 12));
            }
            else
            {
                TitleImage.Location = new Point(12, 12);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            #region Relocating Title and Making Game Visible

            TitleImage.Location = new Point(12, 12);
            StartButton.Visible = false;

            DealerHand.Visible = true;
            PlayerHand.Visible = true;
            Output.Visible = true;
            BettingPanel.Visible = true;
            ProfileButton.Visible = true;
            SaveButton.Visible = true;
            ResetButton.Visible = true;

            #endregion

            gameStarted = true;

            thisGame.AddPlayer(); //add a player to the game

            for(int i = 0; i < 10; i ++)
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
                Size size = new Size(137,200);
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
            if (thisGame.GetBet(1) <= 0)
            {
                Output.Text = "Must bet to play!";
                return;
            }
            if(thisGame.HasSplit(1) && !splitHandDone)
            {
                splitHandDone = true;
                Output.Text = "Player chose to stay on hand 1.";
            }
            else
            {
                Output.Text = "Player choose to stay";
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
            if(thisGame.GetBet(1) <= 0)
            {
                Output.Text = "Must bet to play!";
                return;
            }

            Output.Text = "Player choose to hit.";

            Card hitCard = thisGame.GetDeck().GetCard();
            Hand hand = thisGame.GetPlayerHand(1);
            Hand splitHand = thisGame.GetSplitHand(1);

            if(!thisGame.HasSplit(1))
            {
                hand.AddCard(hitCard);

                DisplayCards(true);
                PlayerCount.Text = hand.GetTotal().ToString();
                if (hand.HasBusted())
                {
                    Output.Text = "Player busted!";
                    this.Hit.Visible = false;
                    this.Stay.Visible = false;
                    Who_Won();
                }
            }
            else if(!splitHandDone)
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
                    if(hand.HasBusted())
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

            if ( dealerHand.GetTotal() < dealerStayValue )
            {
                while ( dealerHand.GetTotal() < dealerStayValue )
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
            Hand playerHand = thisGame.GetPlayerHand(1);
            DisplayCards(false);
            
            if ( thisGame.HasSplit(1))
            {
                Hand splitHand = thisGame.GetSplitHand(1);
                string hand1Result;
                string hand2Result;
                if (playerHand.HasBusted())
                {
                    thisGame.SetPlayerResult(1, GameInstance.GameResult.Loss);
                    hand1Result = "Loss";
                }
                else
                {
                    if(playerHand.GetTotal() == dealerHand.GetTotal())
                    {
                        thisGame.SetPlayerResult(1, GameInstance.GameResult.Standoff);
                        hand1Result = "Standoff";
                    }
                    else if( (playerHand.GetTotal() < dealerHand.GetTotal()) && !dealerHand.HasBusted() )
                    {
                        thisGame.SetPlayerResult(1, GameInstance.GameResult.Loss);
                        hand1Result = "Loss";
                    }
                    else
                    {
                        thisGame.SetPlayerResult(1, GameInstance.GameResult.Win);
                        hand1Result = "Win";
                    }
                }
                if (splitHand.HasBusted())
                {
                    thisGame.SetSplitResult(1, GameInstance.GameResult.Loss);
                    hand2Result = "Loss";
                }
                else
                {
                    if (splitHand.GetTotal() == dealerHand.GetTotal())
                    {
                        thisGame.SetSplitResult(1, GameInstance.GameResult.Standoff);
                        hand2Result = "Standoff";
                    }
                    else if ( (splitHand.GetTotal() < dealerHand.GetTotal()) && !dealerHand.HasBusted() )
                    {
                        thisGame.SetSplitResult(1, GameInstance.GameResult.Loss);
                        hand2Result = "Loss";
                    }
                    else
                    {
                        thisGame.SetSplitResult(1, GameInstance.GameResult.Win);
                        hand2Result = "Win";
                    }
                }
                MessageBox.Show("Hand 1: " + hand1Result + "    Hand 2: " + hand2Result);
            }

            else if ( playerHand.HasBusted())
            {
                MessageBox.Show("Player Busted, Computer Wins");
                thisGame.SetPlayerResult(1, GameInstance.GameResult.Loss);

            }
            else if ( dealerHand.HasBusted())
            {
                MessageBox.Show("Dealer Busted, Player 1 Wins");
                thisGame.SetPlayerResult(1, GameInstance.GameResult.Win);

            }
            else if (playerHand.GetTotal() == 21 && dealerHand.GetTotal() != 21 && playerHand.GetNumberOfCards() == 2)
            {
                MessageBox.Show("Player 1 got a natural blackjack!");
                thisGame.SetPlayerResult(1, GameInstance.GameResult.PlayerBlackjack);

            }
            else if ( playerHand.GetTotal() > dealerHand.GetTotal())
            {
                MessageBox.Show("Player 1 Wins");
                thisGame.SetPlayerResult(1, GameInstance.GameResult.Win);

            }
            else if ( playerHand.GetTotal() == dealerHand.GetTotal())
            {
                MessageBox.Show("Player and dealer tied. No payouts awarded.");
                thisGame.SetPlayerResult(1, GameInstance.GameResult.Standoff);
            }
            else
            {
                MessageBox.Show("Computer Wins");
                thisGame.SetPlayerResult(1, GameInstance.GameResult.Loss);
            }

            playerCash += thisGame.GetPayout(1);
            PlayerCash.Text = playerCash.ToString("C", CultureInfo.CurrentCulture);
            restartAvailable = true;
        }

        private void BetThousand_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 1000;
            CreateBet(BET_AMT, 1);
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
            else if(playerCash <= 0)
            {
                Output.Text = "No money to bet!";
            }
            else
            {
                thisGame.SetBet(1, playerCash);
                Output.Text = "Player went all in!";
                StartRound();
            }
        }

        private void BetFiveHundred_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 500;
            CreateBet(BET_AMT, 1);
        }

        private void BetTwoFifty_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 250;
            CreateBet(BET_AMT, 1);
        }

        private void BetHundred_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 100;
            CreateBet(BET_AMT, 1);
        }

        private void BetFifty_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 50;
            CreateBet(BET_AMT, 1);
        }

        private void BetTwentyFive_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 25;
            CreateBet(BET_AMT, 1);
        }

        private void BetTen_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 10;
            CreateBet(BET_AMT, 1);
        }

        private void BetFive_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 5;
            CreateBet(BET_AMT, 1);
        }

        private void BetOne_Click(object sender, EventArgs e)
        {
            const int BET_AMT = 1;
            CreateBet(BET_AMT, 1);
        }

        private void CreateBet(double BET_AMT, int player)
        {
            if (roundStarted)
            {
                if (thisGame.GetInsuranceAvailaible())
                {
                    if ((thisGame.GetBet(1) / 2) >= BET_AMT)
                    {
                        thisGame.SetInsuranceBet(player, BET_AMT);
                        thisGame.SetInsuranceAvailaible(false);
                        playerCash = playerCash - thisGame.GetInsuranceBet(player);
                        PlayerCash.Text = playerCash.ToString("C", CultureInfo.CurrentCulture);
                        Hit.Visible = true;
                        Stay.Visible = true;
                        Output.Text = "Player bet " + BET_AMT.ToString() + " insurance.";
                        if (thisGame.GetDealerHand().GetTotal() == 21)
                        {
                            thisGame.SetInsuranceWin(1, true);
                            Output.Text = "Insurance bet won!";
                            Who_Won();
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
                PlayerCash.Text = playerCash.ToString("C", CultureInfo.CurrentCulture);
                thisGame.SetBet(1, BET_AMT);
                Output.Text = "Player bet:  $" + thisGame.GetBet(player).ToString() + ".";
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
            
            Hand p1Hand = thisGame.GetPlayerHand(1);
            Hand dealerHand = thisGame.GetDealerHand();

            List<Card> dealerCards = dealerHand.SeeCards();
            List<Card> p1Cards = p1Hand.SeeCards();

            int downValue = 0;
            int i = 0;
            foreach(Card card in dealerCards)
            {
                //PictureBox cardPicture = new PictureBox();
                if (dealerFaceDown)
                {
                    if(i == 0)
                    {
                        dealerCardPictures[i].Image = card.GetImage();
                        if(card.GetCardValue() == Card.CardValue.Ace)
                        {
                            thisGame.SetInsuranceAvailaible(true);
                            Console.WriteLine("Insurance availiable!");
                        }        
                    }

                    else if(i == 1)
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
            if (!thisGame.HasSplit(1))
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
                List<Card> hand1 = thisGame.GetPlayerHand(1).SeeCards();
                List<Card> hand2 = thisGame.GetSplitHand(1).SeeCards();
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
                SplitCount.Text = thisGame.GetSplitHand(1).GetTotal().ToString();
                PlayerCount.Text = p1Hand.GetTotal().ToString();
            }

            
            if(dealerHand.GetTotal() == 21 && !thisGame.GetInsuranceAvailaible())
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
            if (!restartAvailable)
            {
                Output.Text = "Restart not available.";
                return;
            }
            else
            {
                this.Hit.Visible = true;
                this.Stay.Visible = true;
                thisGame.ResetGame();
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
            Hand playerHand = thisGame.GetPlayerHand(1);

            List<Card> dealerCards = dealerHand.SeeCards();
            List<Card> playerCards = playerHand.SeeCards();

            Card testcard1 = new Card(Card.CardValue.Ace, Card.SuiteType.Clubs);
            Card testcard2 = new Card(Card.CardValue.Ten, Card.SuiteType.Clubs);
            Card testcard3 = new Card(Card.CardValue.Five, Card.SuiteType.Hearts);
            Card testcard4 = new Card(Card.CardValue.Five, Card.SuiteType.Spades);
            dealerHand.AddCard(dealingDeck.GetCard());
            dealerHand.AddCard(dealingDeck.GetCard());
            //dealerHand.AddCard(testcard1);
            //dealerHand.AddCard(testcard2);

            playerHand.AddCard(testcard3);
            playerHand.AddCard(testcard4);
            //playerHand.AddCard(dealingDeck.GetCard());
            //playerHand.AddCard(dealingDeck.GetCard());


            Card d1Card = dealerHand.GetCard();
            Card d2Card = dealerHand.GetCard();

            Card p1Card = playerHand.GetCard();
            Card p2Card = playerHand.GetCard();

            DisplayCards(true);
            if(thisGame.GetInsuranceAvailaible() == true)
            {
                InsuranceButton.Visible = true;
            }

            if(p1Card.GetCardValue() == p2Card.GetCardValue())
            {
                SplitButton.Visible = true;
            }

            if((dealerHand.GetTotal() == 21 || playerHand.GetTotal() == 21) && !thisGame.GetInsuranceAvailaible())
            {
                this.Hit.Visible = false;
                this.Stay.Visible = false;
                Who_Won();
            }
        }

        private void InsuranceButton_Click(object sender, EventArgs e)
        {
            Hit.Visible = false;
            Stay.Visible = false;
            InsuranceButton.Visible = false;
            Output.Text = "Please select insurance bet.";


        }

        private void SplitButton_Click(object sender, EventArgs e)
        {
            if(CanBet(thisGame.GetBet(1)))
            {
                SCName.Visible = true;
                PCName.Text = "Hand 1 Count";
                SplitCount.Visible = true;
                Output.Text = "Player chose to split hand.";

                playerCash = playerCash - thisGame.GetBet(1);
                PlayerCash.Text = playerCash.ToString("C", CultureInfo.CurrentCulture);

                thisGame.SetPlayerSplit(1);
                SplitButton.Visible = false;
                Card p1Card = thisGame.GetPlayerHand(1).SeeCards()[0];
                Card p2Card = thisGame.GetPlayerHand(1).SeeCards()[1];
                thisGame.GetPlayerHand(1).ClearHand();
                thisGame.GetPlayerHand(1).AddCard(p1Card);
                thisGame.GetSplitHand(1).AddCard(p2Card);
                DisplayCards(true);
            }
            else
            {
                Output.Text = "Not enough money to split!";
            }
            
        }
    }
}