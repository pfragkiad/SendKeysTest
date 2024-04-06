namespace SendKeysTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            label1 = new Label();
            numSweepInterval = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            numUp = new NumericUpDown();
            numDown = new NumericUpDown();
            tmrNext = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            tstStatus = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)numSweepInterval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDown).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStart.Location = new Point(33, 143);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(207, 46);
            btnStart.TabIndex = 0;
            btnStart.Text = "HACK ROBLOX!";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 28);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 2;
            label1.Text = "Sweep interval [s]:";
            // 
            // numSweepInterval
            // 
            numSweepInterval.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numSweepInterval.Location = new Point(161, 26);
            numSweepInterval.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSweepInterval.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numSweepInterval.Name = "numSweepInterval";
            numSweepInterval.Size = new Size(79, 23);
            numSweepInterval.TabIndex = 3;
            numSweepInterval.TextAlign = HorizontalAlignment.Right;
            numSweepInterval.Value = new decimal(new int[] { 60, 0, 0, 0 });
            numSweepInterval.ValueChanged += NumSweepInterval_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 66);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "Up interval [ms]:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 103);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "Down interval [s]:";
            // 
            // numUp
            // 
            numUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numUp.Location = new Point(161, 64);
            numUp.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numUp.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numUp.Name = "numUp";
            numUp.Size = new Size(79, 23);
            numUp.TabIndex = 3;
            numUp.TextAlign = HorizontalAlignment.Right;
            numUp.Value = new decimal(new int[] { 600, 0, 0, 0 });
            numUp.ValueChanged += NumUp_ValueChanged;
            // 
            // numDown
            // 
            numDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numDown.Location = new Point(161, 101);
            numDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDown.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numDown.Name = "numDown";
            numDown.Size = new Size(79, 23);
            numDown.TabIndex = 3;
            numDown.TextAlign = HorizontalAlignment.Right;
            numDown.Value = new decimal(new int[] { 653, 0, 0, 0 });
            numDown.ValueChanged += NumDown_ValueChanged;
            // 
            // tmrNext
            // 
            tmrNext.Interval = 500;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tstStatus });
            statusStrip1.Location = new Point(0, 207);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(281, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // tstStatus
            // 
            tstStatus.Name = "tstStatus";
            tstStatus.Size = new Size(23, 17);
            tstStatus.Text = "OK";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 229);
            Controls.Add(statusStrip1);
            Controls.Add(numDown);
            Controls.Add(numUp);
            Controls.Add(numSweepInterval);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStart);
            KeyPreview = true;
            Name = "Form1";
            Text = "Wolf Roblox";
            ((System.ComponentModel.ISupportInitialize)numSweepInterval).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDown).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Label label1;
        private NumericUpDown numSweepInterval;
        private Label label2;
        private Label label3;
        private NumericUpDown numUp;
        private NumericUpDown numDown;
        private System.Windows.Forms.Timer tmrNext;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tstStatus;
    }
}
