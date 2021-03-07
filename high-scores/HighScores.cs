using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int> l = new List<int>();

    public HighScores(List<int> list) => l.AddRange(list);

    public List<int> Scores() => l;

    public int Latest() => l.Last();

    public int PersonalBest() => l.Max();

    public List<int> PersonalTopThree()
    {
        List<int> top3 = new List<int>();
        List<int> tempL = new List<int>();
        tempL.AddRange(l);
        int count = 3;
        if (tempL.Count < 3) count = tempL.Count();

        for (int i = 0; i < count; i++)
        {
            top3.Add(tempL.Max());
            tempL.Remove(tempL.Max());
        }
        return top3;
    }
}