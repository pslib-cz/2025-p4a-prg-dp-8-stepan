using ConsoleApp1.Subsystems;

namespace ConsoleApp1.Facade;

public class GameMissionFacade
{
    private readonly MapLoader _mapLoader;
    private readonly CharacterInitializer _characterInitializer;
    private readonly InventoryChecker _inventoryChecker;
    private readonly AudioEngine _audioEngine;
    private readonly HUDManager _hudManager;

    public GameMissionFacade()
    {
        _mapLoader = new MapLoader();
        _characterInitializer = new CharacterInitializer();
        _inventoryChecker = new InventoryChecker();
        _audioEngine = new AudioEngine();
        _hudManager = new HUDManager();
    }

    public void StartMission(string missionName, string playerName, int playerLevel)
    {
        Console.WriteLine($"\n╔══════════════════════════════════════════╗");
        Console.WriteLine($"║  SPOUŠTÍM MISI: {missionName,-24} ║");
        Console.WriteLine($"╚══════════════════════════════════════════╝\n");

        try
        {
            _mapLoader.LoadMapFromFile($"maps/{missionName}.map", 1024);

            _characterInitializer.InitializePlayerCharacter(playerName, playerLevel);
            _characterInitializer.SpawnEnemies(5, "normal");

            int itemCount = _inventoryChecker.CheckInventoryStatus(playerName);
            _inventoryChecker.ValidateEquipment();

            _audioEngine.StartAudioEngine();
            _audioEngine.LoadSoundEffects(new[] { "footsteps", "gunshot", "explosion" });
            _audioEngine.PlayBackgroundMusic($"{missionName}_theme.mp3", 0.7f);

            _hudManager.SetupHUD(showHealthBar: true, showMinimap: true, showQuestLog: true);
            _hudManager.UpdateHUDTheme("dark");

            Console.WriteLine($"\n✓ MISE '{missionName}' ÚSPĚŠNĚ SPUŠTĚNA!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n✗ CHYBA PŘI SPOUŠTĚNÍ MISE: {ex.Message}\n");
            throw;
        }
    }

    public void StartQuickMission(string missionName) => StartMission(missionName, "Player", 1);

    public void EndMission()
    {
        Console.WriteLine("\n╔══════════════════════════════════════════╗");
        Console.WriteLine("║  UKONČUJI MISI                           ║");
        Console.WriteLine("╚══════════════════════════════════════════╝\n");

        _audioEngine.StopAllAudio();
        _hudManager.HideAllHUDElements();
        _characterInitializer.ResetAllCharacters();
        _inventoryChecker.ClearInventory();
        _mapLoader.UnloadCurrentMap();

        Console.WriteLine("\n✓ MISE UKONČENA\n");
    }

    public MapLoader MapLoader => _mapLoader;
    public CharacterInitializer CharacterInitializer => _characterInitializer;
    public InventoryChecker InventoryChecker => _inventoryChecker;
    public AudioEngine AudioEngine => _audioEngine;
    public HUDManager HUDManager => _hudManager;
}
