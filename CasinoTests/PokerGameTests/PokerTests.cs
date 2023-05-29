using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerGame;
using System;
using System.Drawing;

namespace CasinoTests.PokerGameTests
{
    [TestClass]
    public class PokerTests
    {
        private Poker poker;

        [TestInitialize]
        public void Initialize()
        {
            poker = new Poker();
        }

        [TestMethod]
        public void TestBetValueProperty()
        {
            int expectedBetValue = 100;

            poker.BetValue = expectedBetValue;

            Assert.AreEqual(expectedBetValue, poker.BetValue);
        }

        [TestMethod]
        public void TestImagesDictionaryIsNotEmpty()
        {
            var images = poker.Images;

            Assert.IsTrue(images.Count == 52);
        }

        [TestMethod]
        public void TestAddCardToDeck()
        {
            var cardToAdd = "_02trefla";
            var cardImage = poker.Images[cardToAdd];
            poker.RemoveCard(cardToAdd);
            var initialCount = poker.Images.Count;

            poker.AddCard(cardToAdd, cardImage);
            var finalCount = poker.Images.Count;

            Assert.AreEqual(initialCount + 1, finalCount);
        }

        [TestMethod]
        public void TestGetRandomImageReturnsImage()
        {
            var image = poker.GetRandomImage();

            Assert.IsNotNull(image.Value);
            Assert.IsTrue(poker.Images.ContainsKey(image.Key));
        }

        [TestMethod]
        public void TestCalculateWinningsForOnePair()
        {
            string[] highCardImages = { "_02trefla", "_02romb", "_06frunza", "_08inima", "_10trefla" };
            int expectedWinnings = 2; 
            poker.BetValue = 1;

            int actualWinnings = poker.CalculateWinnings(highCardImages);

            Assert.AreEqual(expectedWinnings, actualWinnings);
        }

        [TestMethod]
        public void TestCalculateWinningsForFlush()
        {
            string[] pairImages = { "_02trefla", "_03trefla", "_06trefla", "_08trefla", "_10trefla" };
            int expectedWinnings = 200;
            poker.BetValue = 1;

            int actualWinnings = poker.CalculateWinnings(pairImages);

            Assert.AreEqual(expectedWinnings, actualWinnings);
        }

        [TestMethod]
        public void TestCalculateWinningsForFullHouse()
        {
            string[] twoPairsImages = { "_02trefla", "_02romb", "_02frunza", "_03inima", "_03trefla" };
            int expectedWinnings = 75;
            poker.BetValue = 1;

            int actualWinnings = poker.CalculateWinnings(twoPairsImages);

            Assert.AreEqual(expectedWinnings, actualWinnings);
        }
    }
}
