using System.Runtime.InteropServices;

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

            KeyPresser = new KeyPressLoop();
        }
        KeyPressLoop KeyPresser { get; }

        private void TmrNext_Tick(object? sender, EventArgs e)
        {
            if (!KeyPresser.IsRunning) return;
            tstStatus.Text = "Next sweep in " + KeyPresser.RemainingTimeUntilNextLoopStartTime!.Value.ToString(@"mm\:ss");
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
            if (KeyPresser.IsRunning)
            {
                KeyPresser.CancelLoop();
                return;
            }

            btnStart.Text = "Cancel";

            bool done = await KeyPresser.StartMultipleKeysLoop(
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
            if (KeyPresser is null) return;
            KeyPresser.DelayBetweenLoopsInMs = (int)numSweepInterval.Value * 1000;
        }

        private void NumUp_ValueChanged(object sender, EventArgs e)
        {
            if (KeyPresser?.KeyDurationsInMs is null) return;
            KeyPresser.KeyDurationsInMs[Keys.W] = (int)numUp.Value;

        }

        private void NumDown_ValueChanged(object sender, EventArgs e)
        {
            if (KeyPresser?.KeyDurationsInMs is null) return;
            KeyPresser.KeyDurationsInMs[Keys.S] = (int)numDown.Value;
        }

        #endregion
    }
}
