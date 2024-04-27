using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace SendKeysTest;

public class ScreenshotMaker
{

    [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
    private static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);


    static Bitmap _screenPixel = new(1, 1, PixelFormat.Format32bppArgb);
    public static Color GetColorAt(Point location)
    {
        using (Graphics gdest = Graphics.FromImage(_screenPixel))
        {
            using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
            {
                IntPtr hSrcDC = gsrc.GetHdc();
                IntPtr hDC = gdest.GetHdc();
                int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                gdest.ReleaseHdc();
                gsrc.ReleaseHdc();
            }
        }

        return _screenPixel.GetPixel(0, 0);
    }

    public static Color GetColorAtCurrentPosition()
    {
        return GetColorAt(Cursor.Position);
    }
}
