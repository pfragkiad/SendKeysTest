using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace SendKeysTest;

public static class KeyPresser
{
    // Define structures
    [StructLayout(LayoutKind.Sequential)]
    private struct INPUT
    {
        public int type;
        public MOUSEINPUT mi;
    }

    // Define constants
    private const int INPUT_MOUSE = 0;
    private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
    private const int MOUSEEVENTF_RIGHTUP = 0x0010;
    private const int MOUSEEVENTF_MOVE = 0x0001;
    private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
    private const int SCREEN_WIDTH = 65535;
    private const int SCREEN_HEIGHT = 65535;

    [StructLayout(LayoutKind.Sequential)]
    private struct MOUSEINPUT
    {
        public int dx;
        public int dy;
        public int mouseData;
        public int dwFlags;
        public int time;
        public IntPtr dwExtraInfo;
    }

    [DllImport("user32.dll", SetLastError = true)]
    private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool SetCursorPos(int X, int Y);

    // Define constants
    private const int WM_RBUTTONDOWN = 0x0204;
    private const int WM_RBUTTONUP = 0x0205;
    private const int WM_MOUSEMOVE = 0x0200;

    public static void DragRightClick(IntPtr hwnd, int startX, int startY, int endX, int endY)
    {
        // Perform right mouse down
        SendMouseMessage(hwnd, WM_RBUTTONDOWN, startX, startY);

        // Sleep for a short duration to simulate drag
        Thread.Sleep(100);

        // Perform mouse move to the end position
        SendMouseMessage(hwnd, WM_MOUSEMOVE, endX, endY);

        // Sleep for a short duration to simulate drag
        Thread.Sleep(100);

        // Perform right mouse up
        SendMouseMessage(hwnd, WM_RBUTTONUP, endX, endY);

        //// Perform right mouse down
        //MouseDownRight(absStartX, absStartY);

        //// Sleep for a short duration to simulate drag
        //Thread.Sleep(100);

        //// Perform mouse move
        //MouseMove(absEndX, absEndY);

        //// Sleep for a short duration to simulate drag
        //Thread.Sleep(100);

        //// Perform right mouse up
        //MouseUpRight(absEndX, absEndY);
    }

    // Define constants
 
    static void SendMouseMessage(IntPtr hwnd, uint msg, int x, int y)
    {
        IntPtr lParam = (IntPtr)((y << 16) | (x & 0xFFFF));
        SendMessage(hwnd, msg, IntPtr.Zero, lParam);
    }

    private static void MouseDownRight(int x, int y)
    {
        INPUT[] inputs = new INPUT[1];
        inputs[0].type = INPUT_MOUSE;
        inputs[0].mi.dx = x;
        inputs[0].mi.dy = y;
        inputs[0].mi.dwFlags = MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_ABSOLUTE;
        inputs[0].mi.mouseData = 0;
        inputs[0].mi.time = 0;
        inputs[0].mi.dwExtraInfo = IntPtr.Zero;
        SendInput(1, inputs, Marshal.SizeOf(typeof(INPUT)));
    }

    private static void MouseMove(int x, int y)
    {
        INPUT[] inputs = new INPUT[1];
        inputs[0].type = INPUT_MOUSE;
        inputs[0].mi.dx = x;
        inputs[0].mi.dy = y;
        inputs[0].mi.dwFlags = MOUSEEVENTF_MOVE | MOUSEEVENTF_ABSOLUTE;
        inputs[0].mi.mouseData = 0;
        inputs[0].mi.time = 0;
        inputs[0].mi.dwExtraInfo = IntPtr.Zero;
        SendInput(1, inputs, Marshal.SizeOf(typeof(INPUT)));
    }

    private static void MouseUpRight(int x, int y)
    {
        INPUT[] inputs = new INPUT[1];
        inputs[0].type = INPUT_MOUSE;
        inputs[0].mi.dx = x;
        inputs[0].mi.dy = y;
        inputs[0].mi.dwFlags = MOUSEEVENTF_RIGHTUP | MOUSEEVENTF_ABSOLUTE;
        inputs[0].mi.mouseData = 0;
        inputs[0].mi.time = 0;
        inputs[0].mi.dwExtraInfo = IntPtr.Zero;
        SendInput(1, inputs, Marshal.SizeOf(typeof(INPUT)));
    }
    //----

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


    public static void SendKeyDown(Keys key)
    {
        keybd_event((byte)key, 0, 0, 0);

    }

    public static void SendKeyUp(Keys key)
    {
        keybd_event((byte)key, 0, 2, 0);
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


    public static async Task SendMouseDownRight(IntPtr window)
    {
        const int WM_RBUTTONDOWN = 0x0204;
        const int MK_RBUTTON = 0x0002;

        keybd_event(0, 0, MK_RBUTTON, 0);
        await Task.Delay(10);
        SendMessage(window, WM_RBUTTONDOWN, MK_RBUTTON, 0);
    }

    private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
    private const uint MOUSEEVENTF_LEFTUP = 0x04;
    //private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
    //private const uint MOUSEEVENTF_RIGHTUP = 0x10;


    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

    public static void LeftClick(IntPtr hWnd) => LeftClick(hWnd, Cursor.Position);
  
    public static void LeftClick(IntPtr hWnd, Point p)
    {
        // Set the target window as foreground
        SetForegroundWindow(hWnd);

        // Simulate a left mouse click
        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)p.X, (uint)p.Y, 0, 0);
    }
    public static async Task RightClick(IntPtr hWnd, Point p)
    {
        // Set the target window as foreground
        SetForegroundWindow(hWnd);

        // Simulate a right mouse click
        //mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)p.X, (uint)p.Y, 0, 0);
        //mouse_event(MOUSEEVENTF_RIGHTDOWN, (uint)p.X, (uint)p.Y, 0, 0);

        Cursor.Position = p;

        //simulate drag right for 100 px
        mouse_event(MOUSEEVENTF_RIGHTDOWN, (uint)p.X, (uint)p.Y, 0, 0);

        uint distance = 200;

        ////delay 200 ms
        for (int i = 1; i < distance; i++)
        {
            Cursor.Position = new Point(p.X + i, p.Y);
            await Task.Delay(10); // delay to simulate a real drag
        }
        //drag right for 20 px
        mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)p.X + distance, (uint) p.Y, 0, 0);

    }

    [DllImport("USER32.DLL")]
    private static extern void SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

    public static void CopyWindowImageToClipboard(nint roblox)
    {
        //get the device context of the window using pinvoke    
        
        

    }
}
