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
            bonuses.Add(""Win the Game (+2)"");
        }

        if (margin >= 21)
        {
            stars += 2;
            bonuses.Add(""Win by 21+ (+2)"");
        }
        else if (margin >= 14)
        {
            stars += 2;
            bonuses.Add(""Win by 14+ (+2)"");
        }

        if (shutout)
        {
            stars += 4;
            bonuses.Add(""0 Points Allowed (+4)"");
        }

        if (passYds >= 300)
        {
            stars += 2;
            bonuses.Add(""300+ Pass Yards (+2)"");
        }
        if (rushYds >= 100)
        {
            stars += 2;
            bonuses.Add(""100+ Rush Yards (+2)"");
        }
        if (recYds >= 100)
        {
            stars += 2;
            bonuses.Add(""100+ Rec Yards (+2)"");
        }
        if (passTd >= 3)
        {
            stars += 4;
            bonuses.Add(""3+ Pass TDs (+4)"");
        }
        if (rushTd >= 2)
        {
            stars += 2;
            bonuses.Add(""2+ Rush TDs (+2)"");
        }
        if (recTd >= 2)
        {
            stars += 2;
            bonuses.Add(""2+ Rec TDs (+2)"");
        }

        if (sacks >= 2)
        {
            stars += 2;
            bonuses.Add(""2+ Sacks (+2)"");
        }
        if (ints >= 1)
        {
            stars += 2;
            bonuses.Add(""1+ INT (+2)"");
        }
        if (defTd >= 1)
        {
            stars += 6;
            bonuses.Add(""Def/ST TD (+6)"");
        }
        if (wonTurnover)
        {
            stars += 2;
            bonuses.Add(""Won Turnover Margin (+2)"");
        }
        if (divisional)
        {
            stars += 2;
            bonuses.Add(""Divisional Win (+2)"");
        }
        if (tfl >= 3)
        {
            stars += 2;
            bonuses.Add(""3+ TFL (+2)"");
        }
        if (gongs >= 2)
        {
            stars += 2;
            bonuses.Add(""x2 Gongs (+2)"");
        }

        return new StarCalculation { TotalStars = stars, Bonuses = bonuses };
    }
}
