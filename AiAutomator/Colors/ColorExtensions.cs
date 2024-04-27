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

}
