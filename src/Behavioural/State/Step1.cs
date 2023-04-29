namespace State;

public interface IAudioPlayerState
{
    void Play(AudioPlayer player);
    void Pause(AudioPlayer player);
    void Stop(AudioPlayer player);
}