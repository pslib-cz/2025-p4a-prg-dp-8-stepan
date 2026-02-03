namespace ConsoleApp1.Subsystems;

public class CharacterInitializer
{
    public void InitializePlayerCharacter(string playerName, int level)
    {
        Console.WriteLine($"[CharacterInitializer] Inicializuji hráèe: {playerName}, level {level}");
        Thread.Sleep(300);
        Console.WriteLine("[CharacterInitializer] Hráè inicializován");
    }

    public void SpawnEnemies(int enemyCount, string difficulty)
    {
        Console.WriteLine($"[CharacterInitializer] Spawuji {enemyCount} nepøátel (obtížnost: {difficulty})");
        Thread.Sleep(400);
        Console.WriteLine("[CharacterInitializer] Nepøátelé pøipraveni");
    }

    public void ResetAllCharacters()
    {
        Console.WriteLine("[CharacterInitializer] Resetuji všechny postavy");
    }
}
