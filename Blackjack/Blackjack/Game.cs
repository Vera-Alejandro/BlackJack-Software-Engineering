﻿using System;
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

namespace BlackjackGame
{

    public partial class Blackjack : Form
    {
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
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private bool gameStarted = false;
        private bool roundStarted = false;
        private bool restartAvailable = false;

        private string RunningPath = AppDomain.CurrentDomain.BaseDirectory;

        private GameInstance thisGame = new GameInstance();

        private List<PictureBox> dealerCardPictures = new List<PictureBox>();
        private List<PictureBox> playerCardPictures = new List<PictureBox>();

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

            Sound jazzSound = new Sound("jazz.mp3");
            jazzSound.Play();
        }

        private void Close_Click(object sender, EventArgs e) { Close(); }

        private void Resize_Click(object sender, EventArgs e) 
            { WindowState = (WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized; }

        private void Minimize_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }

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
            if (thisGame.GetBet(1) <= 0)
            {
                Output.Text = "Must bet to play!";
                return;
            }
            Output.Text = "Player choose to stay";
            this.Hit.Visible = false;
            this.Stay.Visible = false;
            Computer_Turn();
        }

        private void Hit_Click(object sender, EventArgs e)
        {
            if(thisGame.GetBet(1) <= 0)
            {
                Output.Text = "Must bet to play!";
                return;
            }

            Output.Text = "Player choose to hit.";

            Card hitCard = thisGame.GetDeck().GetCard();
            Hand hand = thisGame.GetPlayerHand(1);
            hand.AddCard(hitCard);

            DisplayCards(true);
            PlayerCount.Text = hand.GetTotal().ToString();
        }

        private void Computer_Turn()
        {
            int.TryParse(DealerCount.Text, out int dealerCount);
            int.TryParse(PlayerCount.Text, out int playerCount);
            int dealerStayValue = 17;

            Hand dealerHand = thisGame.GetDealerHand();

            if ( dealerHand.GetTotal() < dealerStayValue )
            {
                while ( dealerHand.GetTotal()< dealerStayValue )
                {
                    Card hitCard = thisGame.GetDeck().GetCard();
                    dealerHand.AddCard(hitCard);
                    DisplayCards(false);
                }
            }

            if(dealerCount < 21 && playerCount < 21)
            {
                Who_Won();
            }
        }

        private void Who_Won()
        {
            Hand dealerHand = thisGame.GetDealerHand();
            Hand playerHand = thisGame.GetPlayerHand(1);

            DisplayCards(false);

            if (playerHand.GetTotal() < 21 && dealerHand.GetTotal() < 21)
            {
                if (playerHand.GetTotal() > dealerHand.GetTotal())
                {
                    DealerCount.ForeColor = Color.White;
                    thisGame.SetPlayerResult(1, GameInstance.GameResult.Win);
                    MessageBox.Show("Player 1 Wins");

                }
                else if (playerHand.GetTotal() == dealerHand.GetTotal())
                {
                    DealerCount.ForeColor = Color.White;
                    thisGame.SetPlayerResult(1, GameInstance.GameResult.Standoff);
                    MessageBox.Show("Player and dealer tied. No payouts awarded.");
                }
                else
                {
                    DealerCount.ForeColor = Color.White;
                    thisGame.SetPlayerResult(1, GameInstance.GameResult.Loss);
                    MessageBox.Show("Computer Wins");

                }
                playerCash += thisGame.GetPayout(1);
                PlayerCash.Text = playerCash.ToString("C", CultureInfo.CurrentCulture);
                restartAvailable = true;
            }

        }

        #region Bet Money Functions

        private void BetThousand_Click(object sender, EventArgs e)
        {
            if(roundStarted)
            {
                Output.Text = "Cards already dealt!";
            }
            else if (CanBet(1000))
            {
                thisGame.SetBet(1, 1000);
                Output.Text = "Player bet:  $" + thisGame.GetBet(1).ToString() + ".";
                StartRound();
            }
            else
                Output.Text = "Not enough money to bet!";
        }

        private void BetAll_Click(object sender, EventArgs e)
        {
            if (roundStarted)
            {
                Output.Text = "Cards already dealt!";
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
            if (roundStarted)
            {
                Output.Text = "Cards already dealt!";
            }
            else if (CanBet(500))
            {
                thisGame.SetBet(1, 500);
                Output.Text = "Player bet:  $" + thisGame.GetBet(1).ToString() + ".";
                StartRound();
            }
            else
                Output.Text = "Not enough money to bet!";
        }

        private void BetTwoFifty_Click(object sender, EventArgs e)
        {
            if (roundStarted)
            {
                Output.Text = "Cards already dealt!";
            }
            else if (CanBet(250))
            {
                thisGame.SetBet(1, 250);
                Output.Text = "Player bet:  $" + thisGame.GetBet(1).ToString() + ".";
                StartRound();
            }
            else
                Output.Text = "Not enough money to bet!";
        }

        private void BetHundred_Click(object sender, EventArgs e)
        {
            if (roundStarted)
            {
                Output.Text = "Cards already dealt!";
            }
            else if (CanBet(100))
            {                
                thisGame.SetBet(1, 100);
                Output.Text = "Player bet:  $" + thisGame.GetBet(1).ToString() + ".";
                StartRound();
            }
            else
                Output.Text = "Not enough money to bet!";
        }

        private void BetFifty_Click(object sender, EventArgs e)
        {
            if (roundStarted)
            {
                Output.Text = "Cards already dealt!";
            }
            else if (CanBet(50))
            {
                thisGame.SetBet(1, 50);
                Output.Text = "Player bet:  $" + thisGame.GetBet(1).ToString() + ".";
                StartRound();
            }
            else
                Output.Text = "Not enough money to bet!";
        }

        private void BetTwentyFive_Click(object sender, EventArgs e)
        {
            if (roundStarted)
            {
                Output.Text = "Cards already dealt!";
            }
            else if (CanBet(25))
            {
                thisGame.SetBet(1, 25);
                Output.Text = "Player bet:  $" + thisGame.GetBet(1).ToString() + ".";
                StartRound();
            }
            else
                Output.Text = "Not enough money to bet!";
        }

        private void BetTen_Click(object sender, EventArgs e)
        {
            if (roundStarted)
            {
                Output.Text = "Cards already dealt!";
            }
            else if (CanBet(10))
            {
                thisGame.SetBet(1, 10);
                Output.Text = "Player bet:  $" + thisGame.GetBet(1).ToString() + ".";
                StartRound();
            }
            else
                Output.Text = "Not enough money to bet!";
        }

        private void BetFive_Click(object sender, EventArgs e)
        {
            if (roundStarted)
            {
                Output.Text = "Cards already dealt!";
            }
            else if (CanBet(5))
            {
                thisGame.SetBet(1, 5);
                Output.Text = "Player bet:  $" + thisGame.GetBet(1).ToString() + ".";
                StartRound();
            }
            else
                Output.Text = "Not enough money to bet!";
        }

        private void BetOne_Click(object sender, EventArgs e)
        {
            if (roundStarted)
            {
                Output.Text = "Cards already dealt!";
            }
            else if (CanBet(1))
            {
                thisGame.SetBet(1, 1);
                Output.Text = "Player bet:  $" + thisGame.GetBet(1).ToString() + ".";
                StartRound();
            }
            else
                Output.Text = "Not enough money to bet!";
        }

#endregion

        private void DealerCount_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(DealerCount.Text, out int dealerCount);

            if (dealerCount > 21)
            {
                thisGame.SetPlayerResult(1, GameInstance.GameResult.Win);
                playerCash += thisGame.GetPayout(1);
                PlayerCash.Text = playerCash.ToString("C", CultureInfo.CurrentCulture);
                restartAvailable = true;
                MessageBox.Show("Dealer Busted, Player 1 Wins", "Player Wins!!");
                DealerCount.ForeColor = Color.White;

            }
            else if (dealerCount == 21)
            {
                thisGame.SetPlayerResult(1, GameInstance.GameResult.Loss);
                playerCash += thisGame.GetPayout(1);
                PlayerCash.Text = playerCash.ToString("C", CultureInfo.CurrentCulture);
                restartAvailable = true;
                MessageBox.Show("Dealer got a Blackjack", "Player Lost!");
                DealerCount.ForeColor = Color.White;
            }
        }

        private void PlayerCount_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(PlayerCount.Text, out int playerCount);

        
            if (playerCount > 21)
            {
                Output.Text = "Player busted!";
                this.Hit.Visible = false;
                this.Stay.Visible = false;
                thisGame.SetPlayerResult(1, GameInstance.GameResult.Loss);
                playerCash += thisGame.GetPayout(1);
                PlayerCash.Text = playerCash.ToString("C", CultureInfo.CurrentCulture);
                restartAvailable = true;
                MessageBox.Show("Player Busted, Computer Wins", "Player Lost!");
                DealerCount.ForeColor = Color.White;
                DisplayCards(false);

            }
            else if (playerCount == 21)
            {
                Output.Text = "Player got a Blackjack!!";
                this.Hit.Visible = false;
                this.Stay.Visible = false;
                thisGame.SetPlayerResult(1, GameInstance.GameResult.PlayerBlackjack);
                playerCash += thisGame.GetPayout(1);
                PlayerCash.Text = playerCash.ToString("C", CultureInfo.CurrentCulture);
                restartAvailable = true;
                MessageBox.Show("Player got a natural Blackjack", "Player Wins!!");
                DealerCount.ForeColor = Color.White;
                DisplayCards(false);
            }
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
                if (i == 1 && dealerFaceDown)   //what if we changed this to if (i >= 1) then we can't see the other cards if the dealer were to hit again
                {
                    DealerCount.ForeColor = Color.Black;
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
                else
                {
                    dealerCardPictures[i].Image = card.GetImage();
                }

                dealerCardPictures[i].BringToFront();

                i++;

                if(dealerFaceDown)
                {
                    DealerCount.ForeColor = Color.Black;
                }
                else
                {
                    DealerCount.ForeColor = Color.White;
                }
            }

            i = 0;
            foreach (Card card in p1Cards)
            {
                playerCardPictures[i].Image = card.GetImage();
                playerCardPictures[i].BringToFront();

                i++;
            }

            if(dealerHand.GetTotal() == 21)
            {
                DealerCount.ForeColor = Color.Black;
                dealerCardPictures[1].Image = dealerCards[1].GetImage();
                DealerCount.Text = dealerHand.GetTotal().ToString();
            }
            else
            {
                if(dealerHand.GetTotal() > 21)
                {
                    DealerCount.ForeColor = Color.White;
                }
                else
                {
                    DealerCount.ForeColor = Color.Black;
                }

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
                restartAvailable = false;
                roundStarted = false;
                DealerCount.ForeColor = Color.Black;
                PlayerCount.Text = "0";
            }

        }

        private bool CanBet(int bet)
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

            dealerHand.AddCard(dealingDeck.GetCard());
            dealerHand.AddCard(dealingDeck.GetCard());

            playerHand.AddCard(dealingDeck.GetCard());
            playerHand.AddCard(dealingDeck.GetCard());


            Card d1Card = dealerHand.GetCard();
            Card d2Card = dealerHand.GetCard();

            Card p1Card = playerHand.GetCard();
            Card p2Card = playerHand.GetCard();

            DisplayCards(true);
            if(dealerHand.GetTotal() == 21 || playerHand.GetTotal() == 21)
            {
                this.Hit.Visible = false;
                this.Stay.Visible = false;
                Who_Won();
            }
        }
    }
}