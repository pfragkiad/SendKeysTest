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
            button1 = new Button();
            txtClickNumber = new TextBox();
            picWindow = new PictureBox();
            btnStartTimer = new Button();
            tmrTracker = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            button4 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            label4 = new Label();
            picColor = new PictureBox();
            tstColor = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)numSweepInterval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDown).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWindow).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picColor).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(23, 142);
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
            label1.Location = new Point(23, 28);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 2;
            label1.Text = "Sweep interval [s]:";
            // 
            // numSweepInterval
            // 
            numSweepInterval.Location = new Point(151, 26);
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
            label2.Location = new Point(23, 66);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "Up interval [ms]:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 103);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 2;
            label3.Text = "Down interval [ms]:";
            // 
            // numUp
            // 
            numUp.Location = new Point(151, 64);
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
            numDown.Location = new Point(151, 101);
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
            statusStrip1.Items.AddRange(new ToolStripItem[] { tstStatus, tstColor });
            statusStrip1.Location = new Point(0, 343);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(668, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // tstStatus
            // 
            tstStatus.Name = "tstStatus";
            tstStatus.Size = new Size(622, 17);
            tstStatus.Spring = true;
            tstStatus.Text = "OK";
            tstStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Location = new Point(21, 66);
            button1.Name = "button1";
            button1.Size = new Size(207, 46);
            button1.TabIndex = 5;
            button1.Text = "HACK CLICK!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtClickNumber
            // 
            txtClickNumber.Location = new Point(21, 27);
            txtClickNumber.Name = "txtClickNumber";
            txtClickNumber.Size = new Size(100, 23);
            txtClickNumber.TabIndex = 6;
            txtClickNumber.Text = "1000";
            txtClickNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // picWindow
            // 
            picWindow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picWindow.BorderStyle = BorderStyle.FixedSingle;
            picWindow.Cursor = Cursors.Cross;
            picWindow.Location = new Point(106, 16);
            picWindow.Name = "picWindow";
            picWindow.Size = new Size(513, 256);
            picWindow.SizeMode = PictureBoxSizeMode.StretchImage;
            picWindow.TabIndex = 7;
            picWindow.TabStop = false;
            // 
            // btnStartTimer
            // 
            btnStartTimer.Location = new Point(16, 16);
            btnStartTimer.Name = "btnStartTimer";
            btnStartTimer.Size = new Size(75, 23);
            btnStartTimer.TabIndex = 8;
            btnStartTimer.Text = "Start";
            btnStartTimer.UseVisualStyleBackColor = true;
            btnStartTimer.Click += button2_Click;
            // 
            // tmrTracker
            // 
            tmrTracker.Tick += TmrTracker_Tick;
            // 
            // button3
            // 
            button3.Location = new Point(31, 25);
            button3.Name = "button3";
            button3.Size = new Size(207, 46);
            button3.TabIndex = 0;
            button3.Text = "HACK ROBLOX AI!";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(31, 94);
            button4.Name = "button4";
            button4.Size = new Size(207, 46);
            button4.TabIndex = 0;
            button4.Text = "STOP AI";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(644, 315);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnStart);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(numSweepInterval);
            tabPage1.Controls.Add(numUp);
            tabPage1.Controls.Add(numDown);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(636, 287);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Classic up/down";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(txtClickNumber);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(636, 287);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Fast clicker";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(button4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(636, 287);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "AI test";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(picColor);
            tabPage4.Controls.Add(picWindow);
            tabPage4.Controls.Add(btnStartTimer);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(636, 287);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Bitmap";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 60);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 10;
            label4.Text = "Color:";
            // 
            // picColor
            // 
            picColor.BorderStyle = BorderStyle.FixedSingle;
            picColor.Location = new Point(16, 89);
            picColor.Name = "picColor";
            picColor.Size = new Size(75, 32);
            picColor.TabIndex = 9;
            picColor.TabStop = false;
            // 
            // tstColor
            // 
            tstColor.Name = "tstColor";
            tstColor.Size = new Size(0, 17);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 365);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Wolf Roblox";
            ((System.ComponentModel.ISupportInitialize)numSweepInterval).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDown).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picWindow).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picColor).EndInit();
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
        private Button button1;
        private TextBox txtClickNumber;
        private PictureBox picWindow;
        private Button btnStartTimer;
        private System.Windows.Forms.Timer tmrTracker;
        private Button button3;
        private Button button4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private PictureBox picColor;
        private Label label4;
        private ToolStripStatusLabel tstColor;
    }
}
