namespace ConsoleApp1.Subsystems;

public class AudioEngine
{
    private bool _isInitialized = false;

    public void StartAudioEngine()
    {
        if (!_isInitialized)
        {
            Console.WriteLine("[AudioEngine] Startuji zvukový engine");
            Thread.Sleep(300);
            _isInitialized = true;
            Console.WriteLine("[AudioEngine] Audio engine bìží");
        }
    }

    public void PlayBackgroundMusic(string trackName, float volume)
    {
        if (!_isInitialized)
            throw new InvalidOperationException("Audio engine není inicializován!");
        
        Console.WriteLine($"[AudioEngine] Pøehrávám hudbu: {trackName} (hlasitost: {volume})");
    }

    public void LoadSoundEffects(string[] effectNames)
    {
        Console.WriteLine($"[AudioEngine] Naèítám {effectNames.Length} zvukových efektù");
        Thread.Sleep(250);
        Console.WriteLine("[AudioEngine] Zvukové efekty naèteny");
    }

    public void StopAllAudio()
    {
        Console.WriteLine("[AudioEngine] Zastavuji všechny zvuky");
        _isInitialized = false;
    }
}
