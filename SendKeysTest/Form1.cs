using System.Runtime.InteropServices;

namespace SendKeysTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            numSwipe.Value = (decimal)WolfSettings.Default.SwipeIntervalSeconds;
            numUp.Value = (decimal)WolfSettings.Default.UpDurationMs;
            numDown.Value = (decimal)WolfSettings.Default.DownDurationMs;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            WolfSettings settings = WolfSettings.Default;
            settings.SwipeIntervalSeconds = (int)numSwipe.Value;
            settings.UpDurationMs = (int)numUp.Value;
            settings.DownDurationMs = (int)numDown.Value;
            settings.Save();

            base.OnFormClosing(e);
        }

        CancellationTokenSource? cancelSource = null;

        private async void button1_Click(object sender, EventArgs e)
        {
            if (cancelSource is not null)
            {
                cancelSource.Cancel();
                return;
            }

            try
            {
                cancelSource = new CancellationTokenSource();
                button1.Text = "Cancel";
                while (true)
                {
                    bool done = await UpDown();
                    if (!done)
                    {
                        MessageBox.Show("Failed to focus Roblox window", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    int swapInterval = (int)numSwipe.Value * 1000;
                    await Task.Delay(swapInterval, cancelSource.Token);
                }
                button1.Text = "HACK ROBLOX!";
            }
            catch (TaskCanceledException)
            {
                button1.Text = "HACK ROBLOX!";
            }
            finally
            {
                cancelSource = null;
            }
        }

        private async Task<bool> UpDown()
        {
            if (!KeyPresser.FocusWindow("Roblox"))
                return false;

            int upDuration = (int)numUp.Value; //600;
            int downDuration = (int)numDown.Value;//653;

            //int downDuration = (int)(upDuration * 1.088);

            await KeyPresser.PressKey(Keys.W, upDuration);
            await KeyPresser.PressKey(Keys.S, downDuration);

            return true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if key is esc then stop the timer
            if (e.KeyChar == (char)Keys.Escape)
                timer1.Enabled = false;
        }
    }
}
