namespace ConsoleApp1.Subsystems;

public class HUDManager
{
    public void SetupHUD(bool showHealthBar, bool showMinimap, bool showQuestLog)
    {
        Console.WriteLine("[HUDManager] Nastavuji HUD komponenty");
        if (showHealthBar)
            Console.WriteLine("[HUDManager] - Health bar aktivní");
        if (showMinimap)
            Console.WriteLine("[HUDManager] - Minimapa aktivní");
        if (showQuestLog)
            Console.WriteLine("[HUDManager] - Quest log aktivní");
        
        Thread.Sleep(200);
        Console.WriteLine("[HUDManager] HUD nastaven");
    }

    public void UpdateHUDTheme(string themeName)
    {
        Console.WriteLine($"[HUDManager] Mìním téma HUD na: {themeName}");
    }

    public void HideAllHUDElements()
    {
        Console.WriteLine("[HUDManager] Skrývám všechny HUD elementy");
    }
}
