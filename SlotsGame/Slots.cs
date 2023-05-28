using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace SlotsGame
{
    public partial class Slots : Form
    {
        int autoTimerTickCounter = 0;
        readonly ISoundManager soundManager = new SoundManager();
        readonly ISlotsMachine slotsMachine = new SlotsMachine();
        PictureBox[] pictureBoxes;

        public Slots()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[] { Slot1PictureBox, Slot2PictureBox, Slot3PictureBox };
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (TimerAutoStop.Enabled == false)
            {
                soundManager.StopFailSound();
                soundManager.PlayButtonSound();
                soundManager.PlaySpinSound();
                PlayButton.Text = "Stop";
                TimerSlots1.Enabled = true;
                TimerSlots2.Enabled = true;
                TimerSlots3.Enabled = true;
                TimerAutoStop.Enabled = true;
                slotsMachine.BetValue = (int)BetNumericUpDown.Value;
            }
            else
            {
                soundManager.PlayButtonSound();
                PlayButton.Text = "Play";
                PlayButton.Enabled = false;
                TimerPlayerStop.Enabled = true;
            }
        }

        private void TimerPlayerStop_Tick(object sender, EventArgs e)
        {
            PlayButton.Enabled = true;
            TimerAutoStop.Enabled = false;
            autoTimerTickCounter = 0;
            TimerSlots1.Enabled = false;
            TimerSlots2.Enabled = false;
            TimerSlots3.Enabled = false;
            TimerPlayerStop.Enabled = false;

            soundManager.StopSpinSound();
            WinningsTextBox.Text = slotsMachine.CalculateWinnings(Slot1PictureBox.Name, Slot2PictureBox.Name, Slot3PictureBox.Name).ToString();
            
            if (int.Parse(WinningsTextBox.Text) > 0)
            {
                soundManager.PlayWinSound();
            }
            else
            {
                soundManager.PlayFailSound();
            }
        }

        private void TimerAutoStop_Tick(object sender, EventArgs e)
        {
            autoTimerTickCounter++;
            switch (autoTimerTickCounter)
            {
                case 30:
                    TimerSlots1.Enabled = false;
                    TimerSlots1.Interval = 50;
                    PlayButton.Enabled = false;
                    break;

                case 40:
                    TimerSlots2.Enabled = false;
                    TimerSlots2.Interval = 50;
                    break;

                case 50:
                    autoTimerTickCounter = 0;
                    TimerSlots3.Enabled = false;
                    TimerSlots3.Interval = 50;
                    PlayButton.Text = "Play";
                    PlayButton.Enabled = true;
                    TimerAutoStop.Enabled = false;
                    soundManager.StopSpinSound();
                    WinningsTextBox.Text = slotsMachine.CalculateWinnings(Slot1PictureBox.Name, Slot2PictureBox.Name, Slot3PictureBox.Name).ToString(); ;
                    if (int.Parse(WinningsTextBox.Text) > 0)
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

        private void TimerSlots1_Tick(object sender, EventArgs e)
        {
            UpdateSlotImages(0);
            TimerSlots1.Interval += 3;
        }

        private void TimerSlots2_Tick(object sender, EventArgs e)
        {
            UpdateSlotImages(1);
            TimerSlots2.Interval += 3;
        }

        private void TimerSlots3_Tick(object sender, EventArgs e)
        {
            UpdateSlotImages(2);
            TimerSlots3.Interval += 3;
        }

        private void UpdateSlotImages(int index)
        {
            // Update the card image and the card name display
            KeyValuePair<string, Image> image = slotsMachine.GetRandomImage();
            pictureBoxes[index].Image = image.Value;
            pictureBoxes[index].Name = image.Key;
        }
    }
}
