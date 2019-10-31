using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackjackGame;
using Blackjack;

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
    }
}
