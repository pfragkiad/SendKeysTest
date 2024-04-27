namespace SendKeysTest;

public readonly struct HSV
{
    public HSV(double h, double s, double v)
    {
        H = h;
        S = s;
        V = v;
    }
    public double H { get; }
    public double S { get; }
    public double V { get; }

    public Color ToRgb()
    {
        if (S == 0) return Color.FromArgb((int)(V * 255), (int)(V * 255), (int)(V * 255));

        double h = H / 360.0;
        double s = S;
        double v = V;

        int hi = (int)(Math.Floor(h * 6)) % 6;
        double f = h * 6 - Math.Floor(h * 6);
        double p = v * (1 - s);
        double q = v * (1 - f * s);
        double t = v * (1 - (1 - f) * s);

        double r = 0, g = 0, b = 0;
        switch (hi)
        {
            case 0:
                r = v;
                g = t;
                b = p;
                break;
            case 1:
                r = q;
                g = v;
                b = p;
                break;
            case 2:
                r = p;
                g = v;
                b = t;
                break;
            case 3:
                r = p;
                g = q;
                b = v;
                break;
            case 4:
                r = t;
                g = p;
                b = v;
                break;
            case 5:
                r = v;
                g = p;
                b = q;
                break;
        }

        return Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(b * 255));
    }

    public static HSV FromRgb(Color color)
    {
        double r = color.R / 255.0;
        double g = color.G / 255.0;
        double b = color.B / 255.0;

        double max = Math.Max(r, Math.Max(g, b));
        double min = Math.Min(r, Math.Min(g, b));

        double h = 0, s = 0, v = 0;

        if (max == min)
        {
            h = 0;
        }
        else if (max == r)
        {
            h = 60 * (0 + (g - b) / (max - min));
        }
        else if (max == g)
        {
            h = 60 * (2 + (b - r) / (max - min));
        }
        else if (max == b)
        {
            h = 60 * (4 + (r - g) / (max - min));
        }

        if (h < 0)
        {
            h += 360;
        }

        if (max == 0)
        {
            s = 0;
        }
        else
        {
            s = (max - min) / max;
        }

        v = max;

        return new HSV(h, s, v);
    }

}