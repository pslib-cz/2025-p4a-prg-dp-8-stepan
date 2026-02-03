namespace ConsoleApp1.Subsystems;

public class MapLoader
{
    public bool LoadMapFromFile(string mapPath, int mapSize)
    {
        Console.WriteLine($"[MapLoader] Naèítám mapu z: {mapPath} (velikost: {mapSize})");
        Thread.Sleep(500);
        Console.WriteLine("[MapLoader] Mapa úspìšnì naètena!");
        return true;
    }

    public void UnloadCurrentMap()
    {
        Console.WriteLine("[MapLoader] Uvolòuji mapu z pamìti");
    }
}
