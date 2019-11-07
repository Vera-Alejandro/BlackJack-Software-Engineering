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
using System.IO;

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
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private bool gameStarted = false;

        private string RunningPath = AppDomain.CurrentDomain.BaseDirectory;

        public Blackjack()
        {
            InitializeComponent();
        }

        private void Blackjack_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            TitleImage.Visible = true;
            StartButton.Visible = true;

            string FileName = string.Format("{0}Resources\\sound_assets\\jazz.mp3", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            var backgroundMusic = new System.Windows.Media.MediaPlayer();
            backgroundMusic.Open(new System.Uri(FileName));
            backgroundMusic.Play();
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
            TitleImage.Location = new Point(12, 12);
            StartButton.Visible = false;

            DealerHand.Visible = true;
            PlayerHand.Visible = true;
            Output.Visible = true;
            BettingPanel.Visible = true;
            


            gameStarted = true;

            //deal first card out
            Deck dealingDeck = new Deck();
            Hand dealerHand = new Hand();
            Hand playerHand = new Hand();
            

            dealingDeck.Shuffle();

            dealerHand.AddCard(dealingDeck.GetCard());
            dealerHand.AddCard(dealingDeck.GetCard());

            playerHand.AddCard(dealingDeck.GetCard());
            playerHand.AddCard(dealingDeck.GetCard());

            Card d1Card = dealerHand.GetCard();
            Card d2Card = dealerHand.GetCard();

            Card p1Card = playerHand.GetCard();
            Card p2Card = playerHand.GetCard();

            PictureBox d1Picture = new PictureBox();
            d1Picture.Image = d1Card.GetImage();

            PictureBox d2Picture = new PictureBox();
            d2Picture.Image = d2Card.GetImage();

            DealerHand.Controls.Add(d1Picture);
            DealerHand.Controls.Add(d2Picture);
            d1Picture.Location = new Point(100, 75);
            d2Picture.Location = new Point(150, 125);
            d1Picture.SizeMode = PictureBoxSizeMode.AutoSize;
            d2Picture.SizeMode = PictureBoxSizeMode.AutoSize;
            DealerCount.Text = dealerHand.GetTotal().ToString();

            PictureBox p1Picture = new PictureBox();
            p1Picture.Image = p1Card.GetImage();

            PictureBox p2Picture = new PictureBox();
            p2Picture.Image = p2Card.GetImage();

            PlayerHand.Controls.Add(p1Picture);
            PlayerHand.Controls.Add(p2Picture);
            p1Picture.Location = new Point(100, 75);
            p2Picture.Location = new Point(150, 125);
            p1Picture.SizeMode = PictureBoxSizeMode.AutoSize;
            p2Picture.SizeMode = PictureBoxSizeMode.AutoSize;
            PlayerCount.Text = playerHand.GetTotal().ToString();

            BetThousand.Visible = false;

        }

        private void Stay_Click(object sender, EventArgs e)
        {
            Output.Text = "Player choose to stay";
        }

        private void Hit_Click(object sender, EventArgs e)
        {
            Output.Text = "Player choose to hit.";

            string FileName = string.Format("{0}Resources\\sound_assets\\card_slap.wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            var placeCardSound = new System.Windows.Media.MediaPlayer();
            placeCardSound.Open(new System.Uri(FileName));
            placeCardSound.Play();
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

            if(money > 1)
            {
                BetOne.Visible = true;
                BetFive.Visible = true;
                BetTen.Visible = true;

            }
        }
    }
}