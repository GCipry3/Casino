namespace CasinoLobby.SlotsGame
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