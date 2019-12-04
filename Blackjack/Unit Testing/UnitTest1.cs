using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackjackGame;
using Blackjack;
using SQLite;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;


namespace Unit_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CardShuffleTest()
        {
            Deck regularDeck = new Deck();
            Deck shuffleDeck = new Deck();

            shuffleDeck.Shuffle();

            Card regTest = regularDeck.GetCard();
            Card shuffTest = shuffleDeck.GetCard();

            Assert.AreNotEqual(shuffTest.GetSuiteType(), regTest.GetSuiteType());
            Assert.AreNotEqual(shuffTest.GetCardValue(), regTest.GetCardValue());
        }

        [TestMethod]
        public void TestCardAddingAndGrabbing()
        {
            Card AceCard = new Card(Card.CardValue.Ace, Card.SuiteType.Clubs);
            Card secondCard = new Card(Card.CardValue.Two, Card.SuiteType.Clubs);
            Card thirdCard = new Card(Card.CardValue.Three, Card.SuiteType.Clubs);
            Card fourthCard = new Card(Card.CardValue.Four, Card.SuiteType.Clubs);
            Card fifthCard = new Card(Card.CardValue.Five, Card.SuiteType.Clubs);
            Card sixthCard = new Card(Card.CardValue.Six, Card.SuiteType.Clubs);
            Card seventhCard = new Card(Card.CardValue.Seven, Card.SuiteType.Clubs);
            Card eighthCard = new Card(Card.CardValue.Eight, Card.SuiteType.Clubs);
            Card ninthCard = new Card(Card.CardValue.Nine, Card.SuiteType.Clubs);
            Card tenthCard = new Card(Card.CardValue.Ten, Card.SuiteType.Clubs);
            Card jackCard = new Card(Card.CardValue.Jack, Card.SuiteType.Clubs);
            Card queenCard = new Card(Card.CardValue.Queen, Card.SuiteType.Clubs);
            Card kingCard = new Card(Card.CardValue.King, Card.SuiteType.Clubs);

            Hand testHand = new Hand();
            Random rand = new Random();

            int total = 0;
            int rValue;

            for (int i = 0; i < 100; i++)
            {
                int amountTest = rand.Next(1, 5);
                total = 0;
                for (int k = 0; k < amountTest; k++)
                {
                    rValue = rand.Next(2, 13);
                    if (rValue > 10)
                    {
                        total += 10;
                    }
                    else
                    {
                        total += rValue;
                    }

                    switch(rValue)
                    {
                        case 2:
                            testHand.AddCard(secondCard);
                            break;
                        case 3:
                            testHand.AddCard(thirdCard);
                            break;
                        case 4:
                            testHand.AddCard(fourthCard);
                            break;
                        case 5:
                            testHand.AddCard(fifthCard);
                            break;
                        case 6:
                            testHand.AddCard(sixthCard);
                            break;
                        case 7:
                            testHand.AddCard(seventhCard);
                            break;
                        case 8:
                            testHand.AddCard(eighthCard);
                            break;
                        case 9:
                            testHand.AddCard(ninthCard);
                            break;
                        case 10:
                            testHand.AddCard(tenthCard);
                            break;
                        case 11:
                            testHand.AddCard(jackCard);
                            break;
                        case 12:
                            testHand.AddCard(queenCard);
                            break;
                        case 13:
                            testHand.AddCard(kingCard);
                            break;
                    }
                }

                Assert.AreEqual(total, testHand.GetTotal());
                testHand.ClearHand();
            }


        }


        [TestMethod]
        public void CorrectPayoutsTest()
        {
            GameInstance testGame = new GameInstance();
            testGame.AddPlayer();
            testGame.AddPlayer();
            testGame.AddPlayer();
            testGame.AddPlayer();

            testGame.SetBet(1, 10);
            testGame.SetBet(2, 10);
            testGame.SetBet(3, 10);
            testGame.SetBet(4, 10);

            testGame.SetPlayerResult(1, GameInstance.GameResult.Loss);
            testGame.SetPlayerResult(2, GameInstance.GameResult.Win);
            testGame.SetPlayerResult(3, GameInstance.GameResult.Standoff);
            testGame.SetPlayerResult(4, GameInstance.GameResult.PlayerBlackjack);

            const double CORRECT_LOSS = -10;
            const double CORRECT_WIN = 10;
            const double CORRECT_TIE = 0;
            const double CORRECT_BLACKJACK = 15;

            Assert.AreEqual(testGame.GetPayout(1), CORRECT_LOSS);
            Assert.AreEqual(testGame.GetPayout(2), CORRECT_WIN);
            Assert.AreEqual(testGame.GetPayout(3), CORRECT_TIE);
            Assert.AreEqual(testGame.GetPayout(4), CORRECT_BLACKJACK);
        }
        
        [TestMethod]
        public void DatabaseCreationTest()
        {
            string SQLiteFile = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
            SQLiteFile = Directory.GetParent(SQLiteFile).ToString();
            SQLiteFile = Directory.GetParent(SQLiteFile).ToString();
            SQLiteFile = Path.Combine(SQLiteFile, "GameData.sqlite3");

            try
            {
                Database testdb = new Database(SQLiteFile);

                testdb.Connect();

                testdb.Disconnect();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestEncryption()
        {
            byte[] _password;
            string Password = "Merry_Christmas";
            string pinapple = "who_lives_in_a_pinapple_under_the_sea";
            byte[] salt1 = new byte[8];

            using (RNGCryptoServiceProvider rNGCrypto = new RNGCryptoServiceProvider())
            {
                rNGCrypto.GetBytes(salt1);
            }

            try
            {
                Rfc2898DeriveBytes key1 = new Rfc2898DeriveBytes(pinapple, salt1);
                Rfc2898DeriveBytes key2 = new Rfc2898DeriveBytes(pinapple, salt1);

                TripleDES tripleDES = TripleDES.Create();
                tripleDES.Key = key1.GetBytes(16);
                MemoryStream encryptionStream = new MemoryStream();
                CryptoStream encrypt = new CryptoStream(encryptionStream, tripleDES.CreateDecryptor(), CryptoStreamMode.Write);
                byte[] utfD1 = new System.Text.UTF8Encoding(false).GetBytes(Password);

                encrypt.Write(utfD1, 0, utfD1.Length);
                //encrypt.FlushFinalBlock();
                encrypt.Close();
              
                _password = encryptionStream.ToArray();

                key1.Reset();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                Assert.Fail();
            }
        }
    }
}
