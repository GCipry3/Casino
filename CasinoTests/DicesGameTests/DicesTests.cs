using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DicesGame;

namespace CasinoTests.DicesGameTests
{
    [TestClass]
    public class DicesTests
    {
        GameRule rules;
        DiceFactory diceFactory;
        [TestInitialize]
        public void Initialize()
        {
            rules = new GameRule();
            diceFactory = new DiceFactory("Dice");
        }

        [TestMethod]
        public void TestRules()
        {
            //curent rule is higher
            Assert.AreEqual(2, rules.GetWinner(2, 1));
            Assert.AreEqual(0, rules.GetWinner(1, 1));
            Assert.AreEqual(1, rules.GetWinner(1, 2));

            rules.ChangeGameRule();

            //curent rule is lower 
            Assert.AreEqual(1, rules.GetWinner(2, 1));
            Assert.AreEqual(0, rules.GetWinner(1, 1));
            Assert.AreEqual(2, rules.GetWinner(1, 2));
        }

        [TestMethod]
        public void TestDiceFactoryType()
        {
            Assert.AreEqual("Dice", diceFactory._diceType);
        }
    }
}
