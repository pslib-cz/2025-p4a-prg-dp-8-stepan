# Facade Design Pattern

Facade pattern poskytuje zjednodušené rozhraní pro sloitı systém 5 rùznıch subsystémù (MapLoader, CharacterInitializer, InventoryChecker, AudioEngine, HUDManager), které byly vytvoøeny rùznımi studenty s odlišnımi rozhraními a poadavky. 
Místo psaní 15+ øádkù kódu s rizikem chyb v poøadí volání staèí jeden pøíkaz: `gameFacade.StartMission()`.

## Vıhody
1. **Zjednodušení** - Jeden øádek kódu (`StartMission()`) místo 15+ øádkù volání rùznıch subsystémù
2. **Prevence chyb** - Facade zajišuje správné poøadí volání
3. **Oddìlení závislostí** - Programátor nemusí znát detaily implementace všech subsystémù
4. **Flexibilita** - Pokroèilí uivatelé mohou stále pøistupovat pøímo k jednotlivım subsystémùm pøes properties
5. **Snadná údrba** - Zmìny v subsystémech vyadují úpravu pouze Facade tøídy, nikoliv klientského kódu