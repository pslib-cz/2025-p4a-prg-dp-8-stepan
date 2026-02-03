namespace ConsoleApp1.Subsystems;

public class InventoryChecker
{
    public int CheckInventoryStatus(string playerName)
    {
        Console.WriteLine($"[InventoryChecker] Kontroluji inventáø hráèe: {playerName}");
        Thread.Sleep(200);
        int itemCount = new Random().Next(5, 20);
        Console.WriteLine($"[InventoryChecker] Nalezeno {itemCount} pøedmìtù");
        return itemCount;
    }

    public void ValidateEquipment()
    {
        Console.WriteLine("[InventoryChecker] Validuji vybavení");
        Thread.Sleep(150);
        Console.WriteLine("[InventoryChecker] Vybavení je v poøádku");
    }

    public void ClearInventory()
    {
        Console.WriteLine("[InventoryChecker] Èistím inventáø");
    }
}
