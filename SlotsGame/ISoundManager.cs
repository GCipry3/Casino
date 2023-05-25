using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotsGame
{
    public interface ISoundManager
    {
        void PlaySpinSound();
        void PlayButtonSound();
        void PlayWinSound();
        void PlayFailSound();
        void StopSpinSound();
        void StopStopSound();
        void StopWinSound();
        void StopFailSound();
    }
}
