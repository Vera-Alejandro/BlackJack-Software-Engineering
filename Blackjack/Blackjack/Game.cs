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

        public Blackjack()
        {
            InitializeComponent();
        }

        private void Blackjack_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            TitleImage.Visible = true;
            StartButton.Visible = true;
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

            DealeHand.Visible = true;
            PlayerHand.Visible = true;

            gameStarted = true;

            //deal first card out
            Deck deckDealer = new Deck();
            Deck deckPlayer = new Deck();

        }
    }
}
