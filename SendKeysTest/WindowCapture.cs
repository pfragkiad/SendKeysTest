using OpenCvSharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace SendKeysTest;

public static class WindowCapture
{
    #region pinvoke

    [DllImport("user32.dll")]
    public static extern IntPtr FindWindow(string? lpClassName, string? lpWindowName);

    [DllImport("user32.dll")]
    public static extern IntPtr GetWindowDC(IntPtr hWnd);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDC);

    [DllImport("gdi32.dll")]
    public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

    [DllImport("gdi32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool DeleteDC(IntPtr hdc);

    [DllImport("gdi32.dll")]
    public static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);

    [DllImport("gdi32.dll")]
    public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hObject);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, uint nFlags);

    [DllImport("gdi32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool DeleteObject(IntPtr hObject); // Decl
    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

    // Structures and native functions required for window capture
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    // Constants for PrintWindow
    private const uint PW_CLIENTONLY = 0x00000001;
    private const uint PW_RENDERFULLCONTENT = 0x00000002;

    #endregion

    public static IntPtr GetWindowByTitle(string title) => FindWindow(null, title);

    public static Bitmap? GetWindowBitmap(string title) => GetWindowBitmap(GetWindowByTitle(title));

    public static Bitmap? GetWindowBitmap(IntPtr hWnd)
    {
        // If the window was found
        if (hWnd == IntPtr.Zero) return null;

        // Get the size of the window
        RECT windowRect;
        GetWindowRect(hWnd, out windowRect);
        int width = windowRect.Right - windowRect.Left;
        int height = windowRect.Bottom - windowRect.Top;

        // Create a compatible device context
        IntPtr hdcSrc = GetWindowDC(hWnd);
        IntPtr hdcDest = CreateCompatibleDC(hdcSrc);
        IntPtr hBitmap = CreateCompatibleBitmap(hdcSrc, width, height);
        IntPtr hOld = SelectObject(hdcDest, hBitmap);

        // Copy the window to the device context using PrintWindow
        bool success = PrintWindow(hWnd, hdcDest, PW_RENDERFULLCONTENT);

        // Create a Bitmap from the copied image
        Bitmap bitmap = Bitmap.FromHbitmap(hBitmap);

        // Clean up resources
        SelectObject(hdcDest, hOld);
        DeleteObject(hBitmap);
        DeleteDC(hdcDest);

        ReleaseDC(hWnd, hdcSrc);

        return bitmap;
    }


    public static Mat? GetWindowOpenCvMat(string title) => GetWindowOpenCvMat(GetWindowByTitle(title));

    public static Mat? GetWindowOpenCvMat(IntPtr hWnd)
    {
        Bitmap? bitmap = GetWindowBitmap(hWnd);
        if (bitmap is null) return null;

        return OpenCvSharp.Extensions.BitmapConverter.ToMat(bitmap);
    }

    public static Mat ToOpenCvMat(this Bitmap bitmap) => OpenCvSharp.Extensions.BitmapConverter.ToMat(bitmap);

    public static Bitmap ToBitmap(this Mat mat) => OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat);


    public static Mat? GetMask(IntPtr hWnd, Scalar lower, Scalar upper)
    {
        Mat? mat = GetWindowOpenCvMat(hWnd);
        if(mat is null) return null;
        Cv2.CvtColor(mat, mat, ColorConversionCodes.BGR2HSV);

        //OpenCvSharp.Cv2.GaussianBlur(mat, mat, new OpenCvSharp.Size(11, 11), 0); //works
        //Cv2.Canny(mat, dst, 100, 200); //works

        return GetMask(mat, lower, upper);
    }

    public static Mat? GetMask(Bitmap bitmap, Scalar lower, Scalar upper)
    {
        Mat mat = bitmap.ToOpenCvMat();
        Cv2.CvtColor(mat, mat, ColorConversionCodes.BGR2HSV);
        return GetMask(mat, lower, upper);
    }

    public static Mat GetMask(Mat mat, Scalar lower, Scalar upper)
    {
        Mat mask = new Mat();
        Cv2.InRange(mat, lower, upper, mask);

        //return OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mask);
        return mask;
    }



}
