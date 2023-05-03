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
        public CoinFlip()
        {
            InitializeComponent();
        }

        private void bunifuButtonFlipCoin_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int coinSide = random.Next(0, 2); // 0 for heads, 1 for tails

            Image coinImage;
            string resultText;

            if (coinSide == 0)
            {
                coinImage = Properties.Resources.coin_head; // Replace 'heads' with the name of the heads image in the Resources.resx file
                resultText = "Heads";
            }
            else
            {
                coinImage = Properties.Resources.coin_tail; // Replace 'tails' with the name of the tails image in the Resources.resx file
                resultText = "Tails";
            }

            bunifuPictureBoxCoin.Image = coinImage;

            bunifuLabelResult.Text = resultText;
        }


    }
}
