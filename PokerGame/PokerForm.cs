using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerGame
{
    public partial class PokerForm : Form
    {
        Poker poker = new Poker();
        int tickCounter = 0;
        PictureBox[] pictureBoxes= new PictureBox[5];
        Button[] buttons = new Button[5]; 
        public PokerForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PokerForm_Load(object sender, EventArgs e)
        {
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;

            pictureBoxes[0] = pictureBox1;
            pictureBoxes[1] = pictureBox2;
            pictureBoxes[2] = pictureBox3;
            pictureBoxes[3] = pictureBox4;
            pictureBoxes[4] = pictureBox5;

            for (int i = 0; i < 5; i++)
            {
                UpdatePokerImages(i+1);
                poker.GetItOut(pictureBoxes[i].Name);
            }
        }

        private void UpdatePokerImages(int i)
        {
            KeyValuePair<string, Image> image = poker.GetRandomImage();

            switch (i)
            {
                case 1:
                    pictureBox1.Image = image.Value;
                    pictureBox1.Name = image.Key;
                    break;
                case 2:
                    pictureBox2.Image = image.Value;
                    pictureBox2.Name = image.Key;
                    break;
                case 3:
                    pictureBox3.Image = image.Value;
                    pictureBox3.Name = image.Key;
                    break;
                case 4:
                    pictureBox4.Image = image.Value;
                    pictureBox4.Name = image.Key;
                    break;
                case 5:
                    pictureBox5.Image = image.Value;
                    pictureBox5.Name = image.Key;
                    break;
                default:
                    break;
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if(timerShow.Enabled == false)
            {
                timerShow.Enabled = true;
                PlayButton.Enabled = false;
                poker.BetValue = (int)betNumericUpDown.Value;
                moneyTextBox.Text = poker.BetValue.ToString();
                for (int i = 0; i < 5; i++)
                {
                    buttons[i].Enabled = false;
                    if (buttons[i].Text == "Shuffle")
                    {
                        poker.GetItIn(pictureBoxes[i].Name, pictureBoxes[i].Image);
                    } 
                }
            }
        }

        private void timerShow_Tick(object sender, EventArgs e)
        {
            if (tickCounter == 5)
            {
                tickCounter = 0;
                timerShow.Enabled = false;
                int winnings = poker.CalculateWinnings(pictureBoxes[0].Name, pictureBoxes[1].Name, pictureBoxes[2].Name, pictureBoxes[3].Name, pictureBoxes[4].Name);
                winningsTextBox.Text = winnings.ToString();
                poker.RenewDeck();
                timerBetweenHands.Enabled = true;

            }
            else
            {
                tickCounter++;
                for (int i = 0; i < 5; i++)
                {
                    if (buttons[i].Text == "Shuffle")
                    {
                        UpdatePokerImages(i + 1);
                        if (tickCounter == 4)
                        {
                            poker.GetItOut(pictureBoxes[i].Name);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Keep")
            {
                button1.Text = "Shuffle";
            }
            else if (button1.Text == "Shuffle")
            {
                button1.Text = "Keep";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Keep")
            {
                button2.Text = "Shuffle";
            }
            else if (button2.Text == "Shuffle")
            {
                button2.Text = "Keep";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Keep")
            {
                button3.Text = "Shuffle";
            }
            else if (button3.Text == "Shuffle")
            {
                button3.Text = "Keep";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Keep")
            {
                button4.Text = "Shuffle";
            }
            else if (button4.Text == "Shuffle")
            {
                button4.Text = "Keep";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Keep")
            {
                button5.Text = "Shuffle";
            }
            else if (button5.Text == "Shuffle")
            {
                button5.Text = "Keep";
            }
        }

        private void timerBetweenHands_Tick(object sender, EventArgs e)
        {
            poker.RenewDeck();
            for (int i = 0; i < 5; i++)
            {
                UpdatePokerImages(i+1);
                poker.GetItOut(pictureBoxes[i].Name);
            }
            timerBetweenHands.Enabled = false;
            PlayButton.Enabled = true;
            for (int i = 0; i < 5; i++)
            {
                buttons[i].Text = "Keep";
                buttons[i].Enabled = true;
            }
        }
    }
}
