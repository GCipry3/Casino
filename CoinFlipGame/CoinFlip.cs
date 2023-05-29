using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlipGame
{
    public partial class CoinFlip : Form
    {
        public ICoin coin;
        public int heads;
        public int tails;
        public bool flippingFlag = false;

        public int currentFrame = 0;
        public List<Image> coinFrames;
        public CoinState state;

        public CoinFlip()
        {
            InitializeComponent();
            coin = new CoinFactory("FlipperCoin").CreateCoin();
            comboBoxCoinFace.SelectedIndex = 0;
            state = new NotFlippingState(this);
        }

        private void bunifuButtonFlipCoin_Click(object sender, EventArgs e)
        {
            state.FlipCoin();
        }

        private void timerFlip_Tick(object sender, EventArgs e)
        {
            state.Tick();
        }

        public void UpdateResult()
        {
            string selectedCoinFace = comboBoxCoinFace.SelectedItem?.ToString();
            string resultText = coin.GetResult();
            // Check if the user's selected coin face matches the result
            bunifuLabelResult.Text = (selectedCoinFace == resultText) ? $"You win! The result is {resultText}" : $"You lose. The result is {resultText}";
            if (resultText == "Heads")
                HeadsCountLabel.Text = $"Heads: {++heads}";
            else
                TailsCountLabel.Text = $"Tails: {++tails}";
            state = new NotFlippingState(this);
        }
    }
    
}
