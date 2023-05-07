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
            int index1 = random.Next(slotsMachine.Images.Count);
            int index2 = random.Next(slotsMachine.Images.Count);
            int index3 = random.Next(slotsMachine.Images.Count);

            pictureBox1.Image = slotsMachine.Images.ElementAt(index1).Value;
            pictureBox2.Image = slotsMachine.Images.ElementAt(index2).Value;
            pictureBox3.Image = slotsMachine.Images.ElementAt(index3).Value;

            pictureBox1.Name = slotsMachine.Images.ElementAt(index1).Key;
            pictureBox2.Name = slotsMachine.Images.ElementAt(index2).Key;
            pictureBox3.Name = slotsMachine.Images.ElementAt(index3).Key;
            moneyTextBox.Text = pictureBox1.Name + " "+ pictureBox2.Name + " "+ pictureBox3.Name;

        }

        private void timerStop_Tick(object sender, EventArgs e)
        {
            playButton.Enabled = true;
            timerSlots.Enabled = false;
            timerStop.Enabled = false;
            winningsTextBox.Text = ""+ slotsMachine.CalculateWinnings(pictureBox1.Name + "", pictureBox2.Name + "", pictureBox3.Name + "");
        }
    }

}
