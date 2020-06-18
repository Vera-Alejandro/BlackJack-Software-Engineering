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

        public MainWindow( )
        {
            InitializeComponent();
            StartGame();
        }

        private void ReSizeButton_Click( object sender, RoutedEventArgs e )
            => WindowState = (WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized;

        private void CloseButton_Click( object sender, RoutedEventArgs e ) 
            => Close();

        private void MinButton_Click( object sender, RoutedEventArgs e )
            => WindowState = WindowState.Minimized;


        private void HitButton_Click( object sender, RoutedEventArgs e )
        {

        }

        private void StayButton_Click( object sender, RoutedEventArgs e )
        {

        }

        public void StartGame()
        {
            CurrentGame = new GameInstance();
            Output.Text = "A New game has begun.";
            GenerateImages();
        }

        private void GenerateImages( )
        {
            Image cardDisplay = new Image();

        }

        private void PlayerCash_Loaded( object sender, RoutedEventArgs e )
            => PlayerCash.Text = CurrentGame.GetCash().ToString();
    }
}
