/*
 * Created by: Ohriniuc Claudiu-Constantin
 *
 * Functionality: This file implements the tests for the slots game
 *
*/
using HigherLowerGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlotsGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoTests.SlotsGameTests
{
    [TestClass]
    public class SlotsTests
    {
        private SlotsMachine slotsMachine;
        [TestInitialize]
        public void Initialize()
        {
            slotsMachine = new SlotsMachine();
        }

        [TestMethod]
        public void TestCalculateNoWinnings()
        {
            slotsMachine.BetValue = 10;
            string firstImg = "_7";
            string secondImg = "bananas";
            string thirdImg = "cherries";

            int winnings = slotsMachine.CalculateWinnings(firstImg, secondImg, thirdImg);

            Assert.AreEqual(0, winnings);
        }

        [TestMethod]
        public void TestGetRandomImage()
        {
            var randomImage = slotsMachine.GetRandomImage();

            Assert.IsNotNull(randomImage);
            Assert.IsTrue(slotsMachine.Images.ContainsValue(randomImage.Value));
        }

        [TestMethod]
        public void TestBetValueProperty()
        {
            int expectedValue = 20;

            slotsMachine.BetValue = expectedValue;

            Assert.AreEqual(expectedValue, slotsMachine.BetValue);
        }
    }
}
