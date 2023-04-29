using State;

var audioPlayer = new AudioPlayer();

audioPlayer.Play(); // Starting audio
audioPlayer.Play(); // Already playing
audioPlayer.Pause(); // Pausing audio
audioPlayer.Play(); // Resuming audio
audioPlayer.Stop(); // Stopping audio
audioPlayer.Pause(); // Can't pause. The audio is already stopped