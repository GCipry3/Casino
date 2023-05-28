﻿using System;
using System.Windows.Forms;
using CoinFlipGame;
using SlotsGame;
using DicesGame;
using Users;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Database;
using BlackJackGame;
using PokerGame;
using HigherLowerGame;

namespace CasinoLobby
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CoinFlipButton_Click(object sender, EventArgs e)
        {
            CoinFlip coinFlip = new CoinFlip();  // Initialize the form
            coinFlip.Show();  // Show the form
        }

        private void SlotsButton_Click(object sender, EventArgs e)
        {
            Slots slots = new Slots();
            slots.Show();
        }

        private void DicesGameButton_Click(object sender, EventArgs e)
        {
            Dices dices = new Dices();
            dices.Show();
        }

        private void BlackJackButton_Click(object sender, EventArgs e)
        {
            BlackJack blackJack = new BlackJack();
            blackJack.Show();
        private void PokerButton_Click(object sender, EventArgs e)
        {
            PokerForm poker = new PokerForm();
            poker.Show();
        }

        private void HigherLowerButton_Click(object sender, EventArgs e)
        {
            HigherLower higher = new HigherLower();
            higher.Show();
        }
    }
}
