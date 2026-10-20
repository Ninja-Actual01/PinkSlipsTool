namespace PinkSlipsTool.Models;

public static class M27Perks
{
    // Perks based on the M27 wheel we saw
    // 1. Light Pink: Orange Juice (+2)
    // 2. Purple: Dev Trait Increase  
    // 3. Red: +10 Win Bonus
    // 4. Bright Pink: Any Player (League...)
    // 5. Black: Any Player (Oppon...)
    // 6. Orange: Monstars (1 Skill)
    public static readonly List<PerkDef> WheelPerksM27 = new()
    {
        new() { Name = "Orange Juice (+2)", Description = "Gain +2 Stars", StarCost = 0, Color = "#FF66B2", NeedsDynastyFile = false, ShortName = "OJ +2" },
        new() { Name = "Dev Trait Increase", Description = "Increase a player's development trait", StarCost = 2, Color = "#800080", NeedsDynastyFile = true, ShortName = "Dev Up" },
        new() { Name = "+10 Win Bonus", Description = "Add +10 to your next win margin bonus", StarCost = 6, Color = "#FF0000", NeedsDynastyFile = false, ShortName = "+10 Win" },
        new() { Name = "Any Player (League)", Description = "Steal any player from the league pool", StarCost = 8, Color = "#FF1493", NeedsDynastyFile = true, ShortName = "Steal Lg" },
        new() { Name = "Any Player (Opponent)", Description = "Steal any player from an opponent", StarCost = 6, Color = "#111111", NeedsDynastyFile = true, ShortName = "Steal Opp" },
        new() { Name = "Monstars (1 Skill)", Description = "Grant +1 Skill Point/Upgrade", StarCost = 4, Color = "#FFA500", NeedsDynastyFile = false, ShortName = "Monstars" },
    };
}
