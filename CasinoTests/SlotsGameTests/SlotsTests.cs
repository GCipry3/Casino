using HigherLowerGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlotsGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoTests.SlotsGameTests
{
    /// <summary>
    /// Summary description for SlotsTests
    /// </summary>
    [TestClass]
    public class SlotsTests
    {
        private SlotsMachine slotsMachine;
        [TestInitialize]
        public void Initialize()
        {
            slotsMachine = new SlotsMachine();
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

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
