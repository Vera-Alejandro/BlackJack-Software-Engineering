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

        private bool gameStarted = false;

        private string RunningPath = AppDomain.CurrentDomain.BaseDirectory;

        private GameInstance thisGame = new GameInstance();

        private List<PictureBox> dealerCardPictures = new List<PictureBox>();
        private List<PictureBox> playerCardPictures = new List<PictureBox>();

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

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Resize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
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

            for(int i = 0; i < 7; i ++)
            {
                PictureBox card = new PictureBox();
                playerCardPictures.Add(card);
                playerCardPictures[i].Image = null;
                playerCardPictures[i].Location = new Point((0 + (i * 40)), 75);
                playerCardPictures[i].SizeMode = PictureBoxSizeMode.AutoSize;
                PlayerHand.Controls.Add(playerCardPictures[i]);
                playerCardPictures[i].BringToFront();
            }

 
            for (int i = 0; i < 7; i++)
            {
                PictureBox card = new PictureBox();
                dealerCardPictures.Add(card);
                dealerCardPictures[i].Image = null;
                dealerCardPictures[i].Location = new Point((0 + (i * 40)), 75);
                dealerCardPictures[i].SizeMode = PictureBoxSizeMode.AutoSize;
                DealerHand.Controls.Add(dealerCardPictures[i]);
                dealerCardPictures[i].BringToFront();
            }

            StartRound();

        }

        private void Stay_Click(object sender, EventArgs e)
        {
            Output.Text = "Player choose to stay";
            this.Hit.Visible = false;
            this.Stay.Visible = false;
            Computer_Turn();
        }

        private void Hit_Click(object sender, EventArgs e)
        {
            Output.Text = "Player choose to hit.";

            Card hitCard = thisGame.GetDeck().GetCard();
            Hand hand = thisGame.GetPlayerHand(1);
            hand.AddCard(hitCard);

            DisplayCards(true);
            PlayerCount.Text = hand.GetTotal().ToString();
            if(hand.HasBusted())
            {
                Output.Text = "Player busted!";
                this.Hit.Visible = false;
                this.Stay.Visible = false;
                Who_Won();
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
            Hand dealerHand = thisGame.GetDealerHand();
            Hand playerHand = thisGame.GetPlayerHand(1);
            DisplayCards(false);
            if ( playerHand.HasBusted())
            {
                MessageBox.Show("Player Busted, Computer Wins");
                return;
            }
            else if ( dealerHand.HasBusted())
            {
                MessageBox.Show("Dealer Busted, Player 1 Wins");
                return;
            }
            else if ( playerHand.GetTotal() > dealerHand.GetTotal())
            {
                MessageBox.Show("Player 1 Wins");
                return;
            }
            else
            {
                MessageBox.Show("Computer Wins");
                return;
            }

        }

        private void BetThousand_Click(object sender, EventArgs e)
        {

        }

        private void BetAll_Click(object sender, EventArgs e)
        {

        }

        private void BetFiveHundred_Click(object sender, EventArgs e)
        {

        }

        private void BetTwoFifty_Click(object sender, EventArgs e)
        {

        }

        private void BetHundred_Click(object sender, EventArgs e)
        {

        }

        private void BetFifty_Click(object sender, EventArgs e)
        {

        }

        private void BetTwentyFive_Click(object sender, EventArgs e)
        {

        }

        private void BetTen_Click(object sender, EventArgs e)
        {

        }

        private void BetFive_Click(object sender, EventArgs e)
        {

        }

        private void BetOne_Click(object sender, EventArgs e)
        {

        }

        private void PlayerCash_TextChanged(object sender, EventArgs e)
        {
            int money = Convert.ToInt32(PlayerCash.Text);

            if (money > 1)
            {
                BetOne.Visible = true;
                BetFive.Visible = true;
                BetTen.Visible = true;

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
                //PictureBox cardPicture = new PictureBox();
                if (i == 1 && dealerFaceDown)
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
                else
                {
                    Console.WriteLine("i = " + i);
                    dealerCardPictures[i].Image = card.GetImage();
                }
              //  dealerCardPictures.Location = new Point( (0 + (i * 40)), 75 );
                //dealerCardPicture.SizeMode = PictureBoxSizeMode.AutoSize;
               // DealerHand.Controls.Add(cardPicture);
                dealerCardPictures[i].BringToFront();

                i++;

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
            this.Hit.Visible = true;
            this.Stay.Visible = true;
            thisGame.ResetGame();
            foreach(PictureBox cardPic in dealerCardPictures)
            {
                cardPic.Image = null;
            }
            foreach (PictureBox cardPic in playerCardPictures)
            {
                cardPic.Image = null;
            }

            StartRound();

        }

        private void StartRound()
        {
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
            if(dealerHand.GetTotal() == 21)
            {
                this.Hit.Visible = false;
                this.Stay.Visible = false;
                Who_Won();
            }

            BetThousand.Visible = false;
        }
    }
}