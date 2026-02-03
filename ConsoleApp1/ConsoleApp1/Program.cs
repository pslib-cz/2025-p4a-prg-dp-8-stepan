using ConsoleApp1.Facade;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("FACADE");

        Console.WriteLine("\n\n");

        Console.WriteLine("--- PŘÍKLAD S FACADE ---\n");
        var gameFacade = new GameMissionFacade();
        gameFacade.StartMission("Brumik", "Player1", 5);
        gameFacade.EndMission();


        Console.WriteLine("\n\n");

        Console.WriteLine("--- Vlastní konfigurace ---\n");
        gameFacade.StartQuickMission("Bablebam");

        Console.WriteLine("\n--- Vlastní úpravy (pokročilý uživatel) ---\n");

        // Pokročilý uživatel může přistoupit k jednotlivým subsystémům
        gameFacade.AudioEngine.PlayBackgroundMusic("epic_battle.mp3", 0.9f);
        gameFacade.HUDManager.UpdateHUDTheme("red-alert");
        gameFacade.CharacterInitializer.SpawnEnemies(10, "hard");
    }
}
