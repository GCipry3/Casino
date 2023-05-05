using CasinoLobby.CoinFlipGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CasinoLobby
{
    public partial class CoinFlip : Form
    {
        private ICoin coin;
        private int heads;
        private int tails;
        private bool flippingFlag = false;

        private int currentFrame = 0;
        private List<Image> coinFrames;

        public CoinFlip()
        {
            InitializeComponent();
            coin = new CoinFactory("FlipperCoin").CreateCoin();
            comboBoxCoinFace.SelectedIndex = 0;
        }

        private void bunifuButtonFlipCoin_Click(object sender, EventArgs e)
        {
            // Get the user's selected coin face (Heads or Tails)
            string selectedCoinFace = comboBoxCoinFace.SelectedItem?.ToString();

            // Check if the user has selected a coin face
            if (string.IsNullOrEmpty(selectedCoinFace))
            {
                bunifuLabelResult.Text = "You have to choose the coin face, Heads or Tails";
                return;
            }

            // Flip the coin
            coinFrames = coin.Flip();
            flippingFlag = true;
            bunifuLabelResult.Text = "";
            timerFlip.Start(); // Start the Timer to handle the animation

            // pictureBoxCoin.Image = coinImage;

        }

        private void timerFlip_Tick(object sender, EventArgs e)
        {
            if (flippingFlag && currentFrame < coinFrames.Count)
            {
                pictureBoxCoin.Image = coinFrames[currentFrame++];
            }
            else
            {
                timerFlip.Stop();
                flippingFlag = false;
                currentFrame = 0;
                pictureBoxCoin.Image = coin.GetImage();

                string selectedCoinFace = comboBoxCoinFace.SelectedItem?.ToString();
                string resultText = coin.GetResult();
                // Check if the user's selected coin face matches the result
                bunifuLabelResult.Text = (selectedCoinFace == resultText) ? $"You win! The result is {resultText}" : $"You lose. The result is {resultText}";

                // Increment the heads and tails counter
                if (resultText == "Heads")
                    HeadsCountLabel.Text = $"Heads: {++heads}";
                else
                    TailsCountLabel.Text = $"Tails: {++tails}";
            }
        }
    }
}
