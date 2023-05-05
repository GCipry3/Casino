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
        private ICoin _coin;
        private int _heads;
        private int _tails;
        private bool _flippingFlag = false;

        private int _currentFrame = 0;
        private List<Image> _coinFrames;

        public CoinFlip()
        {
            InitializeComponent();
            _coin = new CoinFactory("FlipperCoin").CreateCoin();
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
            _coinFrames = _coin.Flip();
            _flippingFlag = true;
            bunifuLabelResult.Text = "";
            timerFlip.Start(); // Start the Timer to handle the animation

            // pictureBoxCoin.Image = coinImage;

        }

        private void timerFlip_Tick(object sender, EventArgs e)
        {
            if (_flippingFlag && _currentFrame < _coinFrames.Count)
            {
                pictureBoxCoin.Image = _coinFrames[_currentFrame++];
            }
            else
            {
                timerFlip.Stop();
                _flippingFlag = false;
                _currentFrame = 0;
                pictureBoxCoin.Image = _coin.GetImage();

                string selectedCoinFace = comboBoxCoinFace.SelectedItem?.ToString();
                string resultText = _coin.GetResult();
                // Check if the user's selected coin face matches the result
                bunifuLabelResult.Text = (selectedCoinFace == resultText) ? $"You win! The result is {resultText}" : $"You lose. The result is {resultText}";

                // Increment the heads and tails counter
                if (resultText == "Heads")
                    HeadsCountLabel.Text = $"Heads: {++_heads}";
                else
                    TailsCountLabel.Text = $"Tails: {++_tails}";
            }
        }
    }
}
