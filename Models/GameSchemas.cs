namespace PinkSlipsTool.Models;

public static class GameSchemas
{
    public static GameType DetectGameType(DynastyFile file)
    {
        if (file == null) return GameType.Unknown;
        if (file.GetTable(4248) != null) return GameType.CFB27;
        // M27 detection to be refined when we see actual files
        if (file.Tables.Count > 0) return GameType.Unknown;
        return GameType.Unknown;
    }
}
