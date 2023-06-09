﻿/*
 * Created by: Ohriniuc Claudiu-Constantin
 *
 * Functionality: This implements the interface of the Slots game.
 *
*/
using Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Users;
using Image = System.Drawing.Image;

namespace SlotsGame
{
    public partial class Slots : Form
    {
        // Counter for auto timer ticks.
        int autoTimerTickCounter = 0;
        IUser user;
        IUserDatabase database;
        int winnings;
        int balance;
        int bet;

        // Creating instances of the SoundManager and SlotsMachine.
        readonly SoundManager soundManager = new SoundManager();
        readonly ISlotsMachine slotsMachine = new SlotsMachine();

        // An array to hold PictureBox objects (the three slot images).
        PictureBox[] pictureBoxes;

        public Slots()
        {
            InitializeComponent();
            // Initialize PictureBox array with PictureBoxes for the three slots.
            pictureBoxes = new PictureBox[] { Slot1PictureBox, Slot2PictureBox, Slot3PictureBox };
        }

        public Slots(IUser user, IUserDatabase database)
        {
            InitializeComponent();
            // Initialize PictureBox array with PictureBoxes for the three slots.
            pictureBoxes = new PictureBox[] { Slot1PictureBox, Slot2PictureBox, Slot3PictureBox };
            this.database = database;
            this.user = user;
        }

        private void Slots_Load(object sender, EventArgs e)
        {
            balance = database.GetUserBalance(user.Username);
            MoneyTextBox.Text = balance.ToString();
        }

        // This is the event handler for the Play button click.
        private void PlayButton_Click(object sender, EventArgs e)
        {
            // Check if TimerAutoStop is not enabled. If it is not, it means the game is not currently in play.
            if (TimerAutoStop.Enabled == false)
            {
                // Start the game - stop fail sound if any, play button sound and spin sound, and change Play button text.
                soundManager.StopFailSound();
                soundManager.PlayButtonSound();
                soundManager.PlaySpinSound();
                PlayButton.Text = "Stop";

                // Enable the timers for the three slots.
                TimerSlots1.Enabled = true;
                TimerSlots2.Enabled = true;
                TimerSlots3.Enabled = true;

                // Enable the auto stop timer and set the bet value.
                TimerAutoStop.Enabled = true;
                bet = (int)BetNumericUpDown.Value;
                if (balance >= bet)
                {
                    slotsMachine.BetValue = bet;
                }
                else
                {
                    slotsMachine.BetValue = 0;
                    MessageBox.Show("Your bet cannot be bigger than your balance!");
                }
            }
            else
            {
                // If the game is currently in play and the Play button is clicked, it means the player wants to stop the game.
                soundManager.PlayButtonSound();
                PlayButton.Text = "Play";
                PlayButton.Enabled = false;

                // Enable the player stop timer.
                TimerPlayerStop.Enabled = true;
            }
        }

        // Event handler for TimerPlayerStop.
        private void TimerPlayerStop_Tick(object sender, EventArgs e)
        {
            // Re-enable Play button, disable AutoStop timer, reset autoTimerTickCounter and disable slots timers.
            PlayButton.Enabled = true;
            TimerAutoStop.Enabled = false;
            autoTimerTickCounter = 0;
            TimerSlots1.Enabled = false;
            TimerSlots2.Enabled = false;
            TimerSlots3.Enabled = false;
            TimerPlayerStop.Enabled = false;

            TimerSlots1.Interval = 50;
            TimerSlots2.Interval = 50;
            TimerSlots3.Interval = 50;

            // Stop the spin sound, calculate and display winnings, and play the appropriate sound based on the winnings.
            soundManager.StopSpinSound();
            WinningsHandler();

            if (int.Parse(WinningsTextBox.Text) > 0)
            {
                soundManager.PlayWinSound();
            }
            else
            {
                soundManager.PlayFailSound();
            }
        }

        // Event handler for TimerAutoStop.
        private void TimerAutoStop_Tick(object sender, EventArgs e)
        {
            // Increment the auto timer tick counter.
            autoTimerTickCounter++;

            // Depending on the number of ticks, perform different actions.
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
                    // Reset the auto timer tick counter and perform all actions needed to stop the game.
                    autoTimerTickCounter = 0;
                    TimerSlots3.Enabled = false;
                    TimerSlots3.Interval = 50;
                    PlayButton.Text = "Play";
                    PlayButton.Enabled = true;
                    TimerAutoStop.Enabled = false;

                    soundManager.StopSpinSound();
                    WinningsHandler();
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

        // These are event handlers for each of the three slot timers.
        private void TimerSlots1_Tick(object sender, EventArgs e)
        {
            // Update the slot images and increase the timer interval.
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

        // Method to update slot images.
        private void UpdateSlotImages(int index)
        {
            // Get a random image from the slot machine and update the PictureBox with it.
            KeyValuePair<string, Image> image = slotsMachine.GetRandomImage();
            pictureBoxes[index].Image = image.Value;
            pictureBoxes[index].Name = image.Key;
        }

        private void WinningsHandler()
        {
            winnings = slotsMachine.CalculateWinnings(Slot1PictureBox.Name, Slot2PictureBox.Name, Slot3PictureBox.Name);
            if (winnings > slotsMachine.BetValue)
            {
                database.AddUserBalance(user.Username, winnings);
            }
            else if (winnings == 0)
            {
                database.AddUserBalance(user.Username, -slotsMachine.BetValue);
            }
            MoneyTextBox.Text = database.GetUserBalance(user.Username).ToString();

            WinningsTextBox.Text = winnings.ToString();
        }
    }
}
