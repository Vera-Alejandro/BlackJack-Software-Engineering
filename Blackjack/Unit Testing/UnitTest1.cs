using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackjackGame;

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

            Card regTest = regularDeck.GetFirstCard();
            Card shuffTest = shuffleDeck.GetFirstCard();

            Assert.AreNotEqual(shuffTest.GetSuiteType(), regTest.GetSuiteType());
            Assert.AreNotEqual(shuffTest.GetCardValue(), regTest.GetCardValue());
        }
    }
}
