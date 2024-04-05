using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SendKeysTest;

public class KeyPresser
{
    [DllImport("USER32.DLL")]
    private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

    [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
    private static extern IntPtr FindWindow(string? lpClassName, string lpWindowName);

    [DllImport("USER32.DLL")]
    private static extern bool SetForegroundWindow(IntPtr hWnd);

    public static IntPtr FindWindow(string caption)
        => FindWindow(null, caption);

    public static bool FocusWindow(string caption)
    {
        nint window = FindWindow(caption);
        return SetForegroundWindow(window);
    }

    public static async Task PressKey(Keys key, int delayInMs)
    {
        keybd_event((byte)key, 0, 0, 0);
        await Task.Delay(delayInMs);
        keybd_event((byte)key, 0, 2, 0);
    }
}
