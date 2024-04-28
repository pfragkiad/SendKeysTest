using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiAutomator.Colors;

public static class ColorExtensions
{
    public static HSL ToHSL(this Color color) => HSL.FromRgb(color);

    public static HSV ToHSV(this Color color) => HSV.FromRgb(color);

    public static Scalar ToCvHsv(this Color color)
    {
        HSV hsv = color.ToHSV();
        return new Scalar(
            (int)(hsv.H / 2),
            (int)(hsv.S * 255),
            (int)(hsv.V * 255));
    }

}
