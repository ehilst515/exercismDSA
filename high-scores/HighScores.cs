using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int> l = new List<int>();

    public HighScores(List<int> list) => l.AddRange(list);

    public List<int> Scores() => l;

    public int Latest() => l.Last();

    public int PersonalBest() => l.Max();

    public List<int> PersonalTopThree() => l.OrderByDescending(i => i).Take(3).ToList();
}