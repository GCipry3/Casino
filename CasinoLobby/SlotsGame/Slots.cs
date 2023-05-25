using CasinoLobby.SlotsGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoLobby
{
    public partial class Slots : Form
    {
        int autoTickCounter = 0;
        int winnings;
        ISoundManager soundManager = new SoundManager();
        ISlotsMachine slotsMachine = new SlotsMachine();

        public Slots()
        {
            InitializeComponent();
        }

        private void Slots_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (timerAuto.Enabled == false)
            {

                soundManager.StopFailSound();
                soundManager.PlayButtonSound();
                soundManager.PlaySpinSound();
                playButton.Text = "Stop";
                timerSlots1.Enabled = true;
                timerSlots2.Enabled = true;
                timerSlots3.Enabled = true;
                timerAuto.Enabled = true;
                slotsMachine.BetValue = (int)betNumericUpDown.Value;
            }
            else
            {
                soundManager.PlayButtonSound();
                playButton.Text = "Play";
                playButton.Enabled = false;
                timerStop.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateSlotImages(int i)
        {
            KeyValuePair<string, Image> image = slotsMachine.GetRandomImage();

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
                    moneyTextBox.Text = pictureBox1.Name + " " + pictureBox2.Name + " " + pictureBox3.Name;
                    break;
                default:
                    break;
            }
        }

        private void timerStop_Tick(object sender, EventArgs e)
        {
            playButton.Enabled = true;
            timerAuto.Enabled = false;
            autoTickCounter = 0;
            timerSlots1.Enabled = false;
            timerSlots2.Enabled = false;
            timerSlots3.Enabled = false;
            timerStop.Enabled = false;

            soundManager.StopSpinSound();
            winnings = slotsMachine.CalculateWinnings(pictureBox1.Name + "", pictureBox2.Name + "", pictureBox3.Name + "");
            winningsTextBox.Text = "" + winnings;
            if (winnings > 0)
            {
                soundManager.PlayWinSound();
            }
            else
            {
                soundManager.PlayFailSound();
            }
        }

        private void timerAuto_Tick(object sender, EventArgs e)
        {
            autoTickCounter++;
            switch (autoTickCounter)
            {
                case 30:
                    timerSlots1.Enabled = false;
                    timerSlots1.Interval = 50;
                    playButton.Enabled = false;
                    break;

                case 40:
                    timerSlots2.Enabled = false;
                    timerSlots2.Interval = 50;
                    break;

                case 50:
                    autoTickCounter = 0;
                    timerSlots3.Enabled = false;
                    timerSlots3.Interval = 50;
                    playButton.Text = "Play";
                    playButton.Enabled = true;
                    timerAuto.Enabled = false;
                    soundManager.StopSpinSound();
                    winnings = slotsMachine.CalculateWinnings(pictureBox1.Name + "", pictureBox2.Name + "", pictureBox3.Name + "");
                    winningsTextBox.Text = "" + winnings;
                    if (winnings > 0)
                    {
                        soundManager.PlayWinSound();
                    }
                    else
                    {
                        soundManager.PlayFailSound();
                    }
                    break;

                default:
                    break;
            }
        }

        private void timerSlots1_Tick(object sender, EventArgs e)
        {
            UpdateSlotImages(1);
            timerSlots1.Interval += 3;
        }

        private void timerSlots2_Tick(object sender, EventArgs e)
        {
            UpdateSlotImages(2);
            timerSlots2.Interval += 3;
        }

        private void timerSlots3_Tick(object sender, EventArgs e)
        {
            UpdateSlotImages(3);
            timerSlots3.Interval += 3;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }

}
