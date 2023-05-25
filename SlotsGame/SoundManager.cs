using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Resources;

namespace SlotsGame
{
    public class SoundManager : ISoundManager
    {
        private SoundPlayer _spinSound;
        private SoundPlayer _stopSound;
        private SoundPlayer _winSound;
        private SoundPlayer _failSound;

        public SoundManager()
        {
            _spinSound = new SoundPlayer(Resources.ResourceManager.GetSoundStream("Resources.Resources.spinningSound.wav"));
            _stopSound = new SoundPlayer(Resources.ResourceManager.GetSoundStream("Resources.Resources.pressButtonSound.wav"));
            _winSound = new SoundPlayer(Resources.ResourceManager.GetSoundStream("Resources.Resources.winSound.wav"));
            _failSound = new SoundPlayer(Resources.ResourceManager.GetSoundStream("Resources.Resources.failSound.wav"));
        }

        public void PlaySpinSound()
        {
            _spinSound.Play();
        }

        public void PlayButtonSound()
        {
            _stopSound.Play();
        }

        public void PlayWinSound()
        {
            _winSound.Play();
        }

        public void PlayFailSound()
        {
            _failSound.Play();
        }

        public void StopSpinSound()
        {
            _spinSound.Stop();
        }

        public void StopStopSound()
        {
            _stopSound.Stop();
        }

        public void StopWinSound()
        {
            _winSound.Stop();
        }

        public void StopFailSound()
        {
            _failSound.Stop();
        }
    }
}
