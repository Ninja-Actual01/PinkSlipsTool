namespace PinkSlipsTool.Models;

public static class GameSchemas
{
    public static GameType DetectGameType(DynastyFile file)
    {
        if (file == null) return GameType.Unknown;
        if (file.GetTable(4248) != null)
        {
            // Both can have 4248, but try to be smarter - check context
            // For now, default to CFB27 if loaded from CFB path, else check
            return GameType.CFB27;
        }
        // M27 might use different tables
        if (file.Tables.Count > 0) return GameType.Unknown;
        return GameType.Unknown;
    }
}
