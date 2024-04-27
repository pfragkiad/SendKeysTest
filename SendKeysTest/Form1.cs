using System.Runtime.InteropServices;
using System.Xml;
using OpenCvSharp;

using AiAutomator;
using AiAutomator.Colors;

namespace SendKeysTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadSettings();

            tstStatus.Text = "Stopped";

            tmrNext.Start();
            tmrNext.Tick += TmrNext_Tick;

            _keyPressLoop = new KeyPressLoop();
        }
        KeyPressLoop _keyPressLoop { get; }

        private void TmrNext_Tick(object? sender, EventArgs e)
        {
            if (!_keyPressLoop.IsRunning) return;
            tstStatus.Text = "Next sweep in " + _keyPressLoop.RemainingTimeUntilNextLoopStartTime!.Value.ToString(@"mm\:ss");
        }

        #region Settings
        private void SaveSettings()
        {
            WolfSettings settings = WolfSettings.Default;
            settings.SweepIntervalSeconds = (int)numSweepInterval.Value;
            settings.UpDurationMs = (int)numUp.Value;
            settings.DownDurationMs = (int)numDown.Value;
            settings.Save();
        }


        private void LoadSettings()
        {
            numSweepInterval.Value = (decimal)WolfSettings.Default.SweepIntervalSeconds;
            numUp.Value = (decimal)WolfSettings.Default.UpDurationMs;
            numDown.Value = (decimal)WolfSettings.Default.DownDurationMs;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveSettings();

            base.OnFormClosing(e);
        }


        #endregion

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            if (_keyPressLoop.IsRunning)
            {
                _keyPressLoop.CancelLoop();
                return;
            }

            btnStart.Text = "Cancel";

            bool done = await _keyPressLoop.StartMultipleKeysLoop(
            new Dictionary<Keys, int>
            {
                    { Keys.W, (int)numUp.Value },
                    { Keys.S, (int)numDown.Value }
            }, (int)numSweepInterval.Value * 1000, "Roblox");

            if (!done)
                MessageBox.Show("Failed to focus Roblox window", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else it is cancelled/stopped

            btnStart.Text = "HACK ROBLOX!";
            tstStatus.Text = "Stopped";
        }

        #region NumUpDowns value changed events

        private void NumSweepInterval_ValueChanged(object sender, EventArgs e)
        {
            if (_keyPressLoop is null) return;
            _keyPressLoop.DelayBetweenLoopsInMs = (int)numSweepInterval.Value * 1000;
        }

        private void NumUp_ValueChanged(object sender, EventArgs e)
        {
            if (_keyPressLoop?.KeyDurationsInMs is null) return;
            _keyPressLoop.KeyDurationsInMs[Keys.W] = (int)numUp.Value;

        }

        private void NumDown_ValueChanged(object sender, EventArgs e)
        {
            if (_keyPressLoop?.KeyDurationsInMs is null) return;
            _keyPressLoop.KeyDurationsInMs[Keys.S] = (int)numDown.Value;
        }

        #endregion

        private async void button1_Click(object sender, EventArgs e)
        {
            var roblox = KeyPresser.GetWindowByCaption("Roblox");


            await Task.Delay(5000);

            for (int i = 0; i < int.Parse(txtClickNumber.Text); i++)
            {
                await Task.Delay(Random.Shared.Next(60, 120));
                KeyPresser.LeftClick(roblox);

                //

                //  await Task.Delay(100);
                //  KeyPresser.SendMouseUp(roblox);
                if (i % 100 == 0)
                    tstStatus.Text = i.ToString();
            }

            tstStatus.Text = "Stopped";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tmrTracker.Enabled = !tmrTracker.Enabled;
        }


        IntPtr? _roblox;

        private void TmrTracker_Tick(object sender, EventArgs e)
        {
            try
            {
                Color currentColor = ScreenshotGrabber.GetColorAtCurrentPosition();
                picColor.BackColor = currentColor;
                HSV hsv = currentColor.ToHSV();
                //HSL hsl = currentColor.ToHSL();
                tstColor.Text = $"HSV: {hsv}";



                var w = GetOffset();
                if (!w.HasValue)
                {
                    Text = "STOPPED";
                    return;
                }
                (int whites, int whites2) = w.Value;
                Text = $"whites: {whites}, whites2: {whites2}";//, WIDTH: {width}, HEIGHT: {height}";

                // Capture the window
                if (_roblox is null)
                    _roblox = WindowCapture.GetWindowByTitle("Roblox");

                nint hWnd = _roblox.Value;

                if (_roblox == IntPtr.Zero) return;

                //using Mat mask = WindowCapture.GetMask(_roblox.Value, lower, upper)!;
                using Mat img = WindowCapture.GetWindowOpenCvMat(hWnd)!;

                Bitmap bitmap = img.ToBitmap();

                picWindow.Image?.Dispose();
                picWindow.Image = bitmap;

                ////get the max x with white in dat
                //int width = mask.Cols;
                //int height = mask.Rows;

                //bool IsWhite(Vec3b pixel)
                //{
                //    // Define the white color in RGB
                //    Vec3b white = new Vec3b(255, 255, 255);

                //    // Compare the pixel value with white color
                //    return pixel.Equals(white);
                //}

                ////for (int x = 0; x < dst.Cols; x++)

                //int whites = 0;

                //int x = width / 2;
                //{
                //    //for (int y = 0; y < dst.Rows; y++)
                //    for (int y = 0; y < height; y++)
                //    {
                //        var color = mask.At<Vec3b>(y, x);
                //        if (IsWhite(color))
                //            whites += y - height / 2;
                //    }

                //}

                //int? whites = GetOffset() ?? -9999;

                ////Text = $"X: {maxX} Y: {maxY}, Height: {dst.Rows}, Width: {dst.Cols}";
                //Text = $"whites: {whites}";//, WIDTH: {width}, HEIGHT: {height}";




            }
            catch
            {
                tmrTracker.Stop();
            }


        }

        readonly Scalar lower = new Scalar(0, 110, 121);
        readonly Scalar upper = new Scalar(3, 255, 255);

        (int, int)? GetOffset()
        {
            // Capture the window
            if (_roblox is null)
                _roblox = WindowCapture.GetWindowByTitle("Roblox");

            if (_roblox == IntPtr.Zero) return null;

            using Mat mask = WindowCapture.GetMask(_roblox.Value, lower, upper)!;

            Bitmap bitmap = mask.ToBitmap();

            //pictureBox1.Image?.Dispose();
            //pictureBox1.Image = bitmap;

            //get the max x with white in dat
            int width = mask.Cols;
            int height = mask.Rows;

            static bool IsWhite(Vec3b pixel)
            {
                // Define the white color in RGB
                Vec3b white = new Vec3b(255, 255, 255);

                // Compare the pixel value with white color
                return pixel.Equals(white);
            }

            //for (int x = 0; x < dst.Cols; x++)

            int whites = 0;

            int x = width / 2, y;
            {
                //for (int y = 0; y < dst.Rows; y++)
                for (y = 0; y < height; y++)
                {
                    var color = mask.At<Vec3b>(y, x);
                    if (IsWhite(color))
                        whites += y - height / 2;
                }

            }


            int whites2 = 0;

            y = height / 2;
            {
                //for (int y = 0; y < dst.Rows; y++)
                for (x = 0; x < width; x++)
                {
                    var color = mask.At<Vec3b>(y, x);
                    if (IsWhite(color))
                        whites2 += x - width / 2;
                }

            }



            return (whites, whites2);
        }



        CancellationTokenSource? _cancelSource2;
        CancellationToken _token;
        private async void button3_Click(object sender, EventArgs e)
        {
            _cancelSource2 = new CancellationTokenSource();
            _token = _cancelSource2.Token;

            // Capture the window
            if (_roblox is null)
                _roblox = WindowCapture.GetWindowByTitle("Roblox");

            if (_roblox == IntPtr.Zero) return;

            await Task.Run(async () =>
            {

                await KeyPresser.FocusWindow(_roblox.Value);

                Keys currentKey = Keys.W;
                Keys currentKey2 = Keys.A;


                while (true)
                {
                    _token.ThrowIfCancellationRequested();

                    var w = GetOffset();
                    if (!w.HasValue)
                    {
                        Text = "STOPPED";
                        break;
                    }
                    (int whites, int whites2) = w.Value;
                 //   Text = $"W: {whites}, W2: {whites2}";//, WIDTH: {width}, HEIGHT: {height}";

                    if (whites < -3100)
                        currentKey = Keys.W;
                    else if (whites > 4300)
                        currentKey = Keys.S;

                    if (whites2 < 0 || whites == 0)
                        currentKey2 = Keys.A;
                    else if (whites2 > 1000)
                        currentKey2 = Keys.D;

                    // await Task.Delay(1000);

                    if (whites != 0)
                        await KeyPresser.SendKey(currentKey, 50);

                    await KeyPresser.SendKey(currentKey2, 50);

                }
            });
            _cancelSource2 = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _cancelSource2?.Cancel();
        }
    }
}
