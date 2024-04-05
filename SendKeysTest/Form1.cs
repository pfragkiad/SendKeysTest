using System.Runtime.InteropServices;

namespace SendKeysTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            numericUpDown1.Value = (decimal)WolfSettings.Default.SwapIntervalSeconds;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var settings = WolfSettings.Default;
            settings.SwapIntervalSeconds = (int)numericUpDown1.Value;
            settings.Save();

            base.OnFormClosing(e);
        }

        CancellationTokenSource? cancelSource = null;

        private async void button1_Click(object sender, EventArgs e)
        {
            if (cancelSource is not null)
            {
                cancelSource.Cancel();
                button1.Text = "HACK ROBLOX!";
                return;
            }

            try
            {
                cancelSource = new CancellationTokenSource();
                button1.Text = "Cancel";
                while (true)
                {
                    bool done = await UpDown();
                    if (!done) break;

                    int swapInterval = (int)numericUpDown1.Value * 1000;
                    await Task.Delay(swapInterval, cancelSource.Token);
                }
            }
            catch (TaskCanceledException)
            {
                // ignore
            }
            finally
            {
                cancelSource = null;
            }

        }

        private static async Task<bool> UpDown()
        {
            if (!KeyPresser.FocusWindow("Roblox"))
                return false;


            int upDuration = 600;
            //int downDuration = (int)(upDuration * 1.088);
            int downDuration = 653;

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
