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
            if (timerAuto.Enabled == false)
            {
                playButton.Text = "Stop";
                timerSlots1.Enabled = true;
                timerSlots2.Enabled = true;
                timerSlots3.Enabled = true;
                timerAuto.Enabled = true;
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

        private void UpdateSlotImages(int i)
        {
            Random random = new Random();
            int index = random.Next(slotsMachine.Images.Count);

            switch (i)
            {
                case 1:
                    pictureBox1.Image = slotsMachine.Images.ElementAt(index).Value;
                    pictureBox1.Name = slotsMachine.Images.ElementAt(index).Key;
                    break;
                case 2:
                    pictureBox2.Image = slotsMachine.Images.ElementAt(index).Value;
                    pictureBox2.Name = slotsMachine.Images.ElementAt(index).Key;
                    break;
                case 3:
                    pictureBox3.Image = slotsMachine.Images.ElementAt(index).Value;
                    pictureBox3.Name = slotsMachine.Images.ElementAt(index).Key;
                    moneyTextBox.Text = pictureBox1.Name + " " + pictureBox2.Name + " " + pictureBox3.Name;
                    break;
                default:
                    break;
            }

        }

        private void timerStop_Tick(object sender, EventArgs e)
        {
            playButton.Enabled = true;
            timerSlots1.Enabled = false;
            timerSlots2.Enabled = false;
            timerSlots3.Enabled = false;

            timerStop.Enabled = false;
            winningsTextBox.Text = ""+ slotsMachine.CalculateWinnings(pictureBox1.Name + "", pictureBox2.Name + "", pictureBox3.Name + "");
        }

        private void timerAuto_Tick(object sender, EventArgs e)
        {
            autoTickCounter++;
            switch (autoTickCounter)
            {
                case 8:
                    timerSlots1.Enabled = false;
                    playButton.Enabled = false;
                    break;
                case 13:
                    timerSlots2.Enabled = false;
                    break;
                case 18:
                    autoTickCounter = 0;
                    timerSlots3.Enabled = false;
                    playButton.Text = "Play";
                    playButton.Enabled = true;
                    timerAuto.Enabled = false;
                    winningsTextBox.Text = "" + slotsMachine.CalculateWinnings(pictureBox1.Name + "", pictureBox2.Name + "", pictureBox3.Name + "");

                    break;
                default:
                    break;
            }
            
        }

        private void timerSlots1_Tick(object sender, EventArgs e)
        {
            UpdateSlotImages(1);
        }

        private void timerSlots2_Tick(object sender, EventArgs e)
        {
            UpdateSlotImages(2);
        }

        private void timerSlots3_Tick(object sender, EventArgs e)
        {
            UpdateSlotImages(3);
        }
    }

}
