using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PokerGame
{
    public partial class PokerForm : Form
    {
        Poker poker = new Poker();
        int tickCounter = 0;
        int tickBetweenCounter = 0;
        PictureBox[] pictureBoxes= new PictureBox[5];
        Button[] buttons; 
        public PokerForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PokerForm_Load(object sender, EventArgs e)
        {
            buttons = new Button[] { button1, button2, button3, button4, button5 };
            pictureBoxes = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };

            for (int i = 0; i < 5; i++)
            {
                UpdatePokerImages(i);
                poker.GetItOut(pictureBoxes[i].Name);
            }
        }

        private void UpdatePokerImages(int i)
        {
            KeyValuePair<string, System.Drawing.Image> image = poker.GetRandomImage();
            pictureBoxes[i].Image = image.Value;
            pictureBoxes[i].Name  = image.Key;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if(timerShow.Enabled == false)
            {
                timerShow.Enabled = true;
                PlayButton.Enabled = false;
                betNumericUpDown.Enabled = false;

                poker.BetValue = (int)betNumericUpDown.Value;

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
            if (tickCounter == 9)
            {
                tickCounter = 0;
                timerShow.Enabled = false;
                int winnings = poker.CalculateWinnings(pictureBoxes[0].Name, pictureBoxes[1].Name, pictureBoxes[2].Name, pictureBoxes[3].Name, pictureBoxes[4].Name);
                winningsTextBox.Text = winnings.ToString();
                timerBetweenHands.Enabled = true;
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (buttons[i].Text == "Shuffle" && tickCounter - 4 <= i)
                    {
                        UpdatePokerImages(i);
                        if (tickCounter - 4 == i)
                        {
                            poker.GetItOut(pictureBoxes[i].Name);
                        }
                    }
                }
                tickCounter++;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            buttonChangeText(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonChangeText(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonChangeText(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonChangeText(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonChangeText(4);
        }

        private void timerBetweenHands_Tick(object sender, EventArgs e)
        {
            tickBetweenCounter++;
            if (tickBetweenCounter == 1)
            {
                poker.RenewDeck();
            }
            if (tickBetweenCounter == 11)
            {
                for (int i = 0; i < 5; i++)
                {
                    pictureBoxes[i].Image = Resources.ResourceManager.GetImage("Resources.Resources.cardBack.png");
                }
            }
            if (tickBetweenCounter > 12 && tickBetweenCounter <= 17)
            {
                int index = tickBetweenCounter - 13;
                UpdatePokerImages(index);
                poker.GetItOut(pictureBoxes[index].Name);
            }
            if (tickBetweenCounter == 18)
            {
                tickBetweenCounter = 0;
                timerBetweenHands.Enabled = false;
                PlayButton.Enabled = true;
                betNumericUpDown.Enabled = true;
                for (int i = 0; i < 5; i++)
                {
                    buttons[i].Text = "Keep";
                    buttons[i].Enabled = true;
                }
            }
        }

        private void buttonChangeText(int i)
        {
            buttons[i].Text = (buttons[i].Text == "Keep") ? "Shuffle" : "Keep";
        }
    }
}
