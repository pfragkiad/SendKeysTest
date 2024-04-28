using System.Drawing;
using System.Globalization;

namespace AiAutomator.Colors;


public readonly struct ColorPoint
{
    /// <summary>
    /// X is in the range [0, 1]
    /// </summary>
    public float X { get; init; }

    /// <summary>
    /// Y is in the range [0, 1]
    /// </summary>
    public float Y { get; init; }
    public Color Color { get; init; }

    public PointF ToPointF(Size size)
    {
        return new PointF(X * size.Width, Y * size.Height);
    }

    static CultureInfo EN = new("en-US");
    public override string ToString()
    {
        return string.Create(EN, $"({X},{Y},{Color.R},{Color.G},{Color.B})");
    }


    public static ColorPoint? Parse(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return null;

        string[] parts = s.Trim(['(', ')']).Split(',');
        return new ColorPoint
        {
            X = float.Parse(parts[0], EN),
            Y = float.Parse(parts[1], EN),
            Color = Color.FromArgb(int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]))
        };
    }
}


