using System;
using System.Collections.Generic;
using System.Linq;

public class ScoreStats
{
    private readonly List<double> _scores = new();

    public bool TryAdd(double value, out string? error)
    {
        if (value < 0 || value > 100)
        {
            error = "Invalid score";
            return false;
        }
        _scores.Add(value);
        error = null;
        return true;
    }

    public int Count => _scores.Count;
    public double Sum => _scores.Sum();
    public double Average => _scores.Count == 0 ? 0 : _scores.Average();
    public double Min => _scores.Count == 0 ? 0 : _scores.Min();
    public double Max => _scores.Count == 0 ? 0 : _scores.Max();
}