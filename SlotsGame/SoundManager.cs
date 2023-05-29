using System.Media;

namespace SlotsGame
{
    // This class handles all sounds related to the slots game
    public class SoundManager
    {
        // SoundPlayer for each sound effect in the game
        private SoundPlayer spinSound;
        private SoundPlayer stopSound;
        private SoundPlayer winSound;
        private SoundPlayer failSound;

        // The constructor for the SoundManager class
        public SoundManager()
        {
            // Load each sound file using the Resource Manager
            spinSound = new SoundPlayer(Resources.ResourceManager.GetSoundStream("Resources.Resources.spinningSound.wav"));
            stopSound = new SoundPlayer(Resources.ResourceManager.GetSoundStream("Resources.Resources.pressButtonSound.wav"));
            winSound = new SoundPlayer(Resources.ResourceManager.GetSoundStream("Resources.Resources.winSound.wav"));
            failSound = new SoundPlayer(Resources.ResourceManager.GetSoundStream("Resources.Resources.failSound.wav"));
        }

        // Play sound effects methods
        public void PlaySpinSound()
        {
            spinSound.Play();
        }

        public void PlayButtonSound()
        {
            stopSound.Play();
        }

        public void PlayWinSound()
        {
            winSound.Play();
        }

        public void PlayFailSound()
        {
            failSound.Play();
        }

        // Stop sound effects methods
        public void StopSpinSound()
        {
            spinSound.Stop();
        }

        public void StopStopSound()
        {
            stopSound.Stop();
        }

        public void StopWinSound()
        {
            winSound.Stop();
        }

        public void StopFailSound()
        {
            failSound.Stop();
        }
    }
}
