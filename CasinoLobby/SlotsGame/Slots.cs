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
        SlotsMachine slotsMachine = new SlotsMachine();

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
            if (timerSlots.Enabled == false)
            {
                playButton.Text = "Stop";
                timerSlots.Enabled = true;
                slotsMachine.Bet = (int)betNumericUpDown.Value;
            }
            else
            {
                playButton.Text = "Play";
                playButton.Enabled = false;
                timerStop.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timerSlots_Tick(object sender, EventArgs e)
        {
            UpdateSlotImages();
        }

        private void UpdateSlotImages()
        {
            Random random = new Random();

            pictureBox1.Image = slotsMachine.Images[random.Next(slotsMachine.Images.Count)];
            pictureBox2.Image = slotsMachine.Images[random.Next(slotsMachine.Images.Count)];
            pictureBox3.Image = slotsMachine.Images[random.Next(slotsMachine.Images.Count)];
        }

        private void timerStop_Tick(object sender, EventArgs e)
        {
            playButton.Enabled = true;
            timerSlots.Enabled = false;
            timerStop.Enabled = false;
            winningsTextBox.Text = ""+ slotsMachine.CalculateWinnings(pictureBox1.Image.ToString(),pictureBox2.Image.ToString(),pictureBox3.Image.ToString());
            moneyTextBox.Text = pictureBox1.Image.ToString() + " " + pictureBox2.Image.ToString() + " " + pictureBox3.Image.ToString();
        }
    }

}
