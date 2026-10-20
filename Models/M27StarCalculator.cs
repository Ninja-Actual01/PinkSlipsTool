namespace PinkSlipsTool.Models;

public class M27StarCalculator
{
    public StarCalculation Calculate(int wins, int margin, bool shutout, int passYds, int rushYds, int recYds,
        int passTd, int rushTd, int recTd, int sacks, int ints, int defTd, bool wonTurnover, bool divisional,
        int tfl, int gongs)
    {
        List<string> bonuses = new List<string>();
        int stars = 0;

        if (wins >= 1)
        {
            stars += 2;
            bonuses.Add("WIN THE GAME (+2)");
        }

        if (margin >= 21)
        {
            stars += 2;
            bonuses.Add("WIN BY 21+ (+2)");
        }
        else if (margin >= 14)
        {
            stars += 1;
            bonuses.Add("WIN BY 14+ (+1)");
        }

        if (shutout)
        {
            stars += 2;
            bonuses.Add("0 PTS ALLOWED (+2)");
        }

        if (passYds >= 300)
        {
            stars += 1;
            bonuses.Add("300 PASS YARDS (+1)");
        }
        if (rushYds >= 100)
        {
            stars += 1;
            bonuses.Add("100 RUSH YARDS (+1)");
        }
        if (recYds >= 100)
        {
            stars += 1;
            bonuses.Add("100 REC YARDS (+1)");
        }
        if (passTd >= 3)
        {
            stars += 1;
            bonuses.Add("3 PASS TD (+1)");
        }
        if (rushTd >= 2)
        {
            stars += 1;
            bonuses.Add("2 RUSH TD (+1)");
        }
        if (recTd >= 2)
        {
            stars += 1;
            bonuses.Add("2 REC TD (+1)");
        }

        if (sacks >= 2)
        {
            stars += 1;
            bonuses.Add("2 SACKS (+1)");
        }
        if (ints >= 1)
        {
            stars += 1;
            bonuses.Add("1 INT (+1)");
        }
        if (defTd >= 1)
        {
            stars += 2;
            bonuses.Add("DEF TD (+2)");
        }
        if (wonTurnover)
        {
            stars += 1;
            bonuses.Add("WIN TURNOVER +/- (+1)");
        }
        if (divisional)
        {
            stars += 2;
            bonuses.Add("WIN DIVISIONAL GAME (+2)");
        }
        if (tfl >= 3)
        {
            stars += 1;
            bonuses.Add("3 TFL (+1)");
        }
        if (gongs >= 2)
        {
            stars += 1;
            bonuses.Add("x2 GONGS (+1)");
        }

        return new StarCalculation { TotalStars = stars, ConditionsMet = bonuses };
    }
}
