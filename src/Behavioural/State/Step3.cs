namespace State;

public class AudioPlayer
{
    private IAudioPlayerState _state;

    public AudioPlayer()
    {
        _state = new StoppedState();
    }

    public void SetState(IAudioPlayerState state)
    {
        _state = state;
    }

    public void Play()
    {
        _state.Play(this);
    }

    public void Pause()
    {
        _state.Pause(this);
    }

    public void Stop()
    {
        _state.Stop(this);
    }
}