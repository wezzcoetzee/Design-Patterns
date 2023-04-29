namespace State;

public class PlayingState : IAudioPlayerState
{
    public void Play(AudioPlayer player)
    {
        Console.WriteLine("Already playing.");
    }

    public void Pause(AudioPlayer player)
    {
        Console.WriteLine("Pausing audio.");
        player.SetState(new PausedState());
    }

    public void Stop(AudioPlayer player)
    {
        Console.WriteLine("Stopping audio.");
        player.SetState(new StoppedState());
    }
}

public class PausedState : IAudioPlayerState
{
    public void Play(AudioPlayer player)
    {
        Console.WriteLine("Resuming audio.");
        player.SetState(new PlayingState());
    }

    public void Pause(AudioPlayer player)
    {
        Console.WriteLine("Already paused.");
    }

    public void Stop(AudioPlayer player)
    {
        Console.WriteLine("Stopping audio.");
        player.SetState(new StoppedState());
    }
}

public class StoppedState : IAudioPlayerState
{
    public void Play(AudioPlayer player)
    {
        Console.WriteLine("Starting audio.");
        player.SetState(new PlayingState());
    }

    public void Pause(AudioPlayer player)
    {
        Console.WriteLine("Can't pause. The audio is already stopped.");
    }

    public void Stop(AudioPlayer player)
    {
        Console.WriteLine("Already stopped.");
    }
}