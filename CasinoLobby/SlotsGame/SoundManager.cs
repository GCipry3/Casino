using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CasinoLobby.SlotsGame
{
    public class SoundManager : ISoundManager
    {
        private SoundPlayer _spinSound;
        private SoundPlayer _stopSound;
        private SoundPlayer _winSound;
        private SoundPlayer _failSound;

        public SoundManager()
        {
            _spinSound = new SoundPlayer(Properties.Resources.spinningSound);
            _stopSound = new SoundPlayer(Properties.Resources.pressButtonSound);
            _winSound = new SoundPlayer(Properties.Resources.jackpotSound);
            _failSound = new SoundPlayer(Properties.Resources.failSound);
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
