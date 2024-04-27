using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SendKeysTest;

public static class KeyPresser
{
    [DllImport("USER32.DLL")]
    private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

    [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
    private static extern IntPtr FindWindow(string? lpClassName, string lpWindowName);

    [DllImport("USER32.DLL")]
    private static extern bool SetForegroundWindow(IntPtr hWnd);

    public static IntPtr GetWindowByCaption(string caption)
        => FindWindow(null, caption);

    public static async Task<bool> SendMultipleKeys(
        IDictionary<Keys, int> keyDurations, string windowCaption)
    {
        var window = GetWindowByCaption(windowCaption);

        if (!SetForegroundWindow(window))
            return false;

        await SendMouseDown(window);

        foreach (var entry in keyDurations)
            await SendKey(entry.Key, entry.Value);

        return true;
    }

    public static async Task FocusWindow(IntPtr hWnd)
    {
        if (!SetForegroundWindow(hWnd))
            return;

        await SendMouseDown(hWnd);
    }


    public static async Task SendKey(Keys key, int delayInMs)
    {
        keybd_event((byte)key, 0, 0, 0);
        await Task.Delay(delayInMs);
        keybd_event((byte)key, 0, 2, 0);
    }


    public static async Task SendMouseDown(IntPtr window)
    {
        const int WM_LBUTTONDOWN = 0x0201;
        const int MK_LBUTTON = 0x0001;

        keybd_event(0, 0, MK_LBUTTON, 0);
        await Task.Delay(10);
        SendMessage(window, WM_LBUTTONDOWN, MK_LBUTTON, 0);
    }


    private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
    private const uint MOUSEEVENTF_LEFTUP = 0x04;

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

    public static void LeftClick(IntPtr hWnd)
    {
        // Set the target window as foreground
        SetForegroundWindow(hWnd);

        // Simulate a left mouse click
        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint) Cursor.Position.X , (uint) Cursor.Position.Y, 0, 0);
    }

    [DllImport("USER32.DLL")]
    private static extern void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    public static void CopyWindowImageToClipboard(nint roblox)
    {
        //get the device context of the window using pinvoke    
        
        

    }
}
