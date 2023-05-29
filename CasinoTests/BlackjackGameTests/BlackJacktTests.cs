using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BlackJackGame;
using System.Drawing;
using Resources;

namespace CasinoTests.BlackjackGameTests
{
    [TestClass]
    public class BlackJacktTests
    {
        FlowLayoutPanel panel;
        BlackJack form;
        Image test;
        BlackJackDeck deck;
        List<PictureBox> pictureBoxes;
        BlackJackBetHandler bet;

        [TestInitialize]
        public void Initializa()
        {
            panel = new FlowLayoutPanel();
            form = new BlackJack();
            test = ResourceManager.GetImage("Resources.Resources.cardBack.png");
            deck = new BlackJackDeck();
            pictureBoxes = new List<PictureBox>{
                deck.DisplayPlayerCard("1#trefla_02",test ,panel),
                deck.DisplayPlayerCard("3#trefla_11",test ,panel),
                deck.DisplayPlayerCard("4#frunza_11",test ,panel),
                deck.DisplayPlayerCard("2#inima_14",test ,panel),
            };
            bet = new BlackJackBetHandler();
        }
        //testing if the picture box list i update whenever i display a new card gives me the wanted value
        [TestMethod]
        public void TestCalculatePlayerScore()
        {
            Assert.AreEqual(form.CalculatePlayerScore(pictureBoxes),14);
        }
        [TestMethod]
        public void TestGetScore()
        {
            Assert.AreEqual(bet.GetScore(new List<int> { 11, 3, 4 }), 18);
            Assert.AreEqual(bet.GetScore(new List<int> { 11, 3, 4 }), 18);
            Assert.AreEqual(bet.GetScore(new List<int> { 11, 3, 4 }), 18);
            Assert.AreEqual(bet.GetScore(new List<int> { 11, 11, 14 }), 12);
            Assert.AreEqual(bet.GetScore(new List<int> { 11, 11, 11, 10, 11 }), 14);
            Assert.AreEqual(bet.GetScore(new List<int> { 11, 13, 14 }), 21);
            Assert.AreEqual(bet.GetScore(new List<int> { 11, 11, 10, 14, 13 }), 32);
        }
    }
}
