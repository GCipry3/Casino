using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using HigherLowerGame;

namespace CasinoTests.higherLowerTests
{
    /// <summary>
    /// Summary description for HigherLowerTests
    /// </summary>
    [TestClass]
    public class HigherLowerTests
    {
        private HigherLowerGame.HigherLowerGame higherLower;

        [TestInitialize]
        public void Initialize()
        {
            higherLower = new HigherLowerGame.HigherLowerGame();
        }

        [TestMethod]
        public void TestCalculateWinnings()
        {
            higherLower.BetValue = 10;
            higherLower.Option = "higher";
            string firstImg = "_02trefla";
            string secondImg = "_03trefla";

            int winnings = higherLower.CalculateWinnings(firstImg, secondImg);

            Assert.AreEqual(50, winnings);
        }

        [TestMethod]
        public void TestCalculateWinnings_NoWin()
        {
            higherLower.BetValue = 10;
            higherLower.Option = "higher";
            string firstImg = "_05trefla";
            string secondImg = "_04trefla";

            int winnings = higherLower.CalculateWinnings(firstImg, secondImg);

            Assert.AreEqual(0, winnings);
        }

        [TestMethod]
        public void TestRemoveCard_NotExistingCard()
        {
            string imgToRemove = "_21trefla";

            higherLower.RemoveCard(imgToRemove);

            Assert.AreEqual(52, higherLower.Images.Count);
        }

        [TestMethod]
        public void TestRemoveCard()
        {
            string imgToRemove = "_02trefla";

            higherLower.RemoveCard(imgToRemove);

            Assert.IsFalse(higherLower.Images.ContainsKey(imgToRemove));
        }

        [TestMethod]
        public void TestGetRandomImage()
        {
            KeyValuePair<string, System.Drawing.Image> randomImage = higherLower.GetRandomImage();

            Assert.IsNotNull(randomImage);
            Assert.IsTrue(higherLower.Images.ContainsValue(randomImage.Value));
        }
    }
}
