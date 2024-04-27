using System.Drawing;

namespace AiAutomator.Colors;

public readonly struct HSL
{
    public HSL(double h, double s, double l)
    {
        H = h;
        S = s;
        L = l;
    }

    // H is int in the range [0, 360]
    public double H { get; }

    // S and L are in the range [0, 1]
    public double S { get; }

    public double L { get; }

    public Color ToRgb()
    {
        if (S == 0) return Color.FromArgb((int)(L * 255), (int)(L * 255), (int)(L * 255));

        double q = L < 0.5 ? L * (1 + S) : L + S - L * S;
        double p = 2 * L - q;

        double h = H / 360.0;
        const double onethird = 1.0 / 3;

        double r = HueToRgb(p, q, h + onethird);
        double g = HueToRgb(p, q, h);
        double b = HueToRgb(p, q, h - onethird);

        return Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(b * 255));
    }


    private static double HueToRgb(double p, double q, double t)
    {
        if (t < 0)
        {
            t += 1;
        }
        if (t > 1)
        {
            t -= 1;
        }
        if (t < 1.0 / 6)
        {
            return p + (q - p) * 6 * t;
        }
        if (t < 1.0 / 2)
        {
            return q;
        }
        if (t < 2.0 / 3)
        {
            return p + (q - p) * (2.0 / 3 - t) * 6;
        }
        return p;
    }


    public static HSL FromRgb(Color color)
    {
        double r = color.R;
        double g = color.G;
        double b = color.B;

        double h = 0, s = 0, l = 0;

        double rPercent = r / 255.0;
        double gPercent = g / 255.0;
        double bPercent = b / 255.0;

        double max = Math.Max(rPercent, Math.Max(gPercent, bPercent));
        double min = Math.Min(rPercent, Math.Min(gPercent, bPercent));

        if (max == min)
        {
            h = 0;
        }
        else if (max == rPercent)
        {
            h = 60 * (0 + (gPercent - bPercent) / (max - min));
        }
        else if (max == gPercent)
        {
            h = 60 * (2 + (bPercent - rPercent) / (max - min));
        }
        else if (max == bPercent)
        {
            h = 60 * (4 + (rPercent - gPercent) / (max - min));
        }

        if (h < 0)
        {
            h += 360;
        }

        l = (max + min) / 2;

        if (max == min)
        {
            s = 0;
        }
        else if (l <= 0.5)
        {
            s = (max - min) / (max + min);
        }
        else
        {
            s = (max - min) / (2 - max - min);
        }

        return new HSL(h, s, l);
    }


    public override string ToString()
    {
        return $"H: {H:0}, {S:P0}, {L:P0}";
    }


}
