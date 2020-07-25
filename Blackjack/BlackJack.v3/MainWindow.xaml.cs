using Blackjack.GamePlay;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace BlackJack.v3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected GameInstance CurrentGame;

        public MainWindow()
        {
            InitializeComponent();
            StartGame();
        }

        private void ReSizeButton_Click(object sender, RoutedEventArgs e)
            => WindowState = (WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized;

        private void CloseButton_Click(object sender, RoutedEventArgs e)
            => Close();

        private void MinButton_Click(object sender, RoutedEventArgs e)
            => WindowState = WindowState.Minimized;


        private void HitButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StayButton_Click(object sender, RoutedEventArgs e)
        {

        }

        public void StartGame()
        {
            CurrentGame = new GameInstance();
            Output.Text = "A New game has begun.";
            GenerateImages();
            UpdateCash();
        }

        private void GenerateImages()
        {
            //Image displayImg = new Image();
            BitmapImage bitmap = new BitmapImage();

            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"A:\Temp\Card Back.png");
            bitmap.EndInit();


            displayImg.BindingGroup = new System.Windows.Data.BindingGroup();
            displayImg.IsEnabled = true;
            displayImg.Margin = new Thickness(0, 90, 160, 0);
            displayImg.Height = 350;
            displayImg.Width= 240;
            displayImg.Source = bitmap;

            //PlayerBettingPanel.Children.Add(displayImg);
        }

        private void UpdateCash()
           => PlayerCash.Text = CurrentGame.GetCash().ToString();
    }
}
