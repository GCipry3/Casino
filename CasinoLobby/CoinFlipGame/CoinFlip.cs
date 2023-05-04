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
        private int _heads;
        private int _tails;
        private ICoin _coin;

        public CoinFlip()
        {
            InitializeComponent();
            _coin = new MockCoin();
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
            _coin.Flip();
            Image coinImage = _coin.GetImage();
            string resultText = _coin.GetResult();

            pictureBoxCoin.Image = coinImage;

            // Check if the user's selected coin face matches the result
            bunifuLabelResult.Text = (selectedCoinFace == resultText) ? $"You win! The result is {resultText}" : $"You lose. The result is {resultText}";
        }
    }
}
