﻿using CasinoLobby.SlotsGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoLobby
{
    public partial class HigherLower : Form
    {
        HigherLowerGame.HigherLowerGame higherLowerGame = new HigherLowerGame.HigherLowerGame();
        int tickCounter = 0;
        string lastCard;

        public HigherLower()
        {
            InitializeComponent();
        }

        private void HigherLower_Load(object sender, EventArgs e)
        {
            shuffleTimer.Enabled = true;
        }

        private void UpdateHLImages()
        {
            KeyValuePair<string, Image> image = higherLowerGame.GetRandomImage();
            pictureBox1.Image = image.Value;
            pictureBox1.Name = image.Key;
            moneyTextBox.Text = pictureBox1.Name + " ";
        }

        private void shuffleTimer_Tick(object sender, EventArgs e)
        {
            tickCounter++;
            if (tickCounter == 5)
            {
                shuffleTimer.Stop();
                tickCounter = 0;
                higherButton.Enabled = true;
                lowerButton.Enabled = true;
                lastCard = pictureBox1.Name + " ";
                winningsTextBox.Text = lastCard;
            }
            else
            {
                UpdateHLImages();
            }
        }

        private void higherButton_Click(object sender, EventArgs e)
        {
            if (shuffleTimer.Enabled)
            {
                lowerButton.Enabled = false;
                higherButton.Enabled = false;
            }
            else
            {
                lowerButton.Enabled = true;
                higherButton.Enabled = true;
                shuffleTimer.Enabled = true;
            }
        }

        private void lowerButton_Click(object sender, EventArgs e)
        {
            if(shuffleTimer.Enabled)
            {
                lowerButton.Enabled = false;
                higherButton.Enabled = false;
            }
            else
            {
                higherButton.Enabled = true;
                lowerButton.Enabled = true;
                shuffleTimer.Enabled = true;
            }
        }
    }
}
