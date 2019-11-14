using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Blackjack.Storage;
using BlackjackGame;
using System.Drawing;

namespace Blackjack
{
    public class GamePlay
    {
        private bool gameStarted { get; set; }
        private GameData _gameData { get; set; }
        internal Deck dealingDeck { get; set; }
        internal Hand dealerHand { get; set; }
        internal Hand playerHand { get; set; }

        public GamePlay()
        {

            bool gameStarted = false;
            GameData _gameData;
            Deck dealingDeck = new Deck();
            Hand dealerHand = new Hand();
            Hand playerHand = new Hand();

            string path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            path = Path.Combine(path, "GameStats.gstat");

            //get the serialized object
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //formatter.Serialize(stream, _gameData);
            //stream.Close();
            _gameData = (GameData)formatter.Deserialize(stream);

            gameStarted = true;
        }

        public void StartGame()
        {
            //deal first card out

            dealingDeck.Shuffle();

            dealerHand.AddCard(dealingDeck.GetCard());
            dealerHand.AddCard(dealingDeck.GetCard());

            playerHand.AddCard(dealingDeck.GetCard());
            playerHand.AddCard(dealingDeck.GetCard());

            Card d1Card = dealerHand.GetCard();
            Card d2Card = dealerHand.GetCard();

            Card p1Card = playerHand.GetCard();
            Card p2Card = playerHand.GetCard();
        }

        public Image GetPlayerCardImage()
        {
            Card returnImage;
            returnImage = playerHand.GetCard();
            return returnImage.GetImage();
        }
        
        public Image GetDealerCardImage()
        {
            Card returnImage = dealerHand.GetCard();
            return returnImage.GetImage();
        }
    }
}
