﻿using System;
using System.Windows.Forms;
using CoinFlipGame;
using SlotsGame;
using HigherLowerGame;
using DicesGame;

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void higherLowerButton_Click(object sender, EventArgs e)
        {
            HigherLower higher = new HigherLower();
            higher.Show();
        }

        private void DicesGameButton_Click(object sender, EventArgs e)
        {
            Dices dices = new Dices();
            dices.Show();
        }
    }
}
