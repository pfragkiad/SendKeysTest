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
            tstColor = new ToolStripStatusLabel();
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
            chkExitAtNextClick = new CheckBox();
            chkKeepStartPoint = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            button5 = new Button();
            txtInterval = new TextBox();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            button2 = new Button();
            splitContainer1 = new SplitContainer();
            picMask = new PictureBox();
            lblCoords = new Label();
            lblUpper = new Label();
            lblLower = new Label();
            groupBox1 = new GroupBox();
            radioUpper = new RadioButton();
            radioLower = new RadioButton();
            radioNone = new RadioButton();
            label4 = new Label();
            picColor = new PictureBox();
            chkWithE = new CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMask).BeginInit();
            groupBox1.SuspendLayout();
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
            statusStrip1.Location = new Point(0, 632);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1062, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // tstStatus
            // 
            tstStatus.Name = "tstStatus";
            tstStatus.Size = new Size(1047, 17);
            tstStatus.Spring = true;
            tstStatus.Text = "OK";
            tstStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tstColor
            // 
            tstColor.Name = "tstColor";
            tstColor.Size = new Size(0, 17);
            // 
            // button1
            // 
            button1.Location = new Point(21, 105);
            button1.Name = "button1";
            button1.Size = new Size(207, 46);
            button1.TabIndex = 5;
            button1.Text = "HACK CLICK!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtClickNumber
            // 
            txtClickNumber.Location = new Point(128, 29);
            txtClickNumber.Name = "txtClickNumber";
            txtClickNumber.Size = new Size(100, 23);
            txtClickNumber.TabIndex = 6;
            txtClickNumber.Text = "1000000";
            txtClickNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // picWindow
            // 
            picWindow.BorderStyle = BorderStyle.FixedSingle;
            picWindow.Cursor = Cursors.Cross;
            picWindow.Dock = DockStyle.Fill;
            picWindow.Location = new Point(0, 0);
            picWindow.Name = "picWindow";
            picWindow.Size = new Size(379, 538);
            picWindow.SizeMode = PictureBoxSizeMode.CenterImage;
            picWindow.TabIndex = 7;
            picWindow.TabStop = false;
            picWindow.Paint += picWindow_Paint;
            picWindow.MouseClick += picWindow_MouseClick;
            picWindow.MouseDown += picWindow_MouseDown;
            picWindow.MouseMove += picWindow_MouseMove;
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
            tabControl1.Size = new Size(1038, 604);
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
            tabPage1.Size = new Size(1030, 576);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Classic up/down";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(chkWithE);
            tabPage2.Controls.Add(chkExitAtNextClick);
            tabPage2.Controls.Add(chkKeepStartPoint);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(txtInterval);
            tabPage2.Controls.Add(txtClickNumber);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1030, 576);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Fast clicker";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkExitAtNextClick
            // 
            chkExitAtNextClick.AutoSize = true;
            chkExitAtNextClick.Location = new Point(21, 204);
            chkExitAtNextClick.Name = "chkExitAtNextClick";
            chkExitAtNextClick.Size = new Size(111, 19);
            chkExitAtNextClick.TabIndex = 9;
            chkExitAtNextClick.Text = "Exit at next click";
            chkExitAtNextClick.UseVisualStyleBackColor = true;
            // 
            // chkKeepStartPoint
            // 
            chkKeepStartPoint.AutoSize = true;
            chkKeepStartPoint.Checked = true;
            chkKeepStartPoint.CheckState = CheckState.Checked;
            chkKeepStartPoint.Location = new Point(21, 168);
            chkKeepStartPoint.Name = "chkKeepStartPoint";
            chkKeepStartPoint.Size = new Size(109, 19);
            chkKeepStartPoint.TabIndex = 8;
            chkKeepStartPoint.Text = "Keep start point";
            chkKeepStartPoint.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 72);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 7;
            label6.Text = "Interval [ms]:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 32);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 7;
            label5.Text = "Count:";
            // 
            // button5
            // 
            button5.Location = new Point(258, 105);
            button5.Name = "button5";
            button5.Size = new Size(207, 46);
            button5.TabIndex = 5;
            button5.Text = "HACK CLICK!";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtInterval
            // 
            txtInterval.Location = new Point(128, 69);
            txtInterval.Name = "txtInterval";
            txtInterval.Size = new Size(100, 23);
            txtInterval.TabIndex = 6;
            txtInterval.Text = "20000";
            txtInterval.TextAlign = HorizontalAlignment.Right;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(button4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1030, 576);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "AI test";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(splitContainer1);
            tabPage4.Controls.Add(lblCoords);
            tabPage4.Controls.Add(lblUpper);
            tabPage4.Controls.Add(lblLower);
            tabPage4.Controls.Add(groupBox1);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(picColor);
            tabPage4.Controls.Add(btnStartTimer);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1030, 576);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Bitmap";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(17, 368);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(202, 16);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(picWindow);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(picMask);
            splitContainer1.Size = new Size(810, 538);
            splitContainer1.SplitterDistance = 379;
            splitContainer1.TabIndex = 14;
            // 
            // picMask
            // 
            picMask.BorderStyle = BorderStyle.FixedSingle;
            picMask.Cursor = Cursors.Cross;
            picMask.Dock = DockStyle.Fill;
            picMask.Location = new Point(0, 0);
            picMask.Name = "picMask";
            picMask.Size = new Size(427, 538);
            picMask.SizeMode = PictureBoxSizeMode.CenterImage;
            picMask.TabIndex = 7;
            picMask.TabStop = false;
            picMask.Paint += picMask_Paint;
            // 
            // lblCoords
            // 
            lblCoords.AutoSize = true;
            lblCoords.Location = new Point(17, 409);
            lblCoords.Name = "lblCoords";
            lblCoords.Size = new Size(61, 15);
            lblCoords.TabIndex = 13;
            lblCoords.Text = "<Coords>";
            // 
            // lblUpper
            // 
            lblUpper.AutoSize = true;
            lblUpper.Location = new Point(17, 333);
            lblUpper.Name = "lblUpper";
            lblUpper.Size = new Size(55, 15);
            lblUpper.TabIndex = 13;
            lblUpper.Text = "<Upper>";
            // 
            // lblLower
            // 
            lblLower.AutoSize = true;
            lblLower.Location = new Point(16, 303);
            lblLower.Name = "lblLower";
            lblLower.Size = new Size(55, 15);
            lblLower.TabIndex = 13;
            lblLower.Text = "<Lower>";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioUpper);
            groupBox1.Controls.Add(radioLower);
            groupBox1.Controls.Add(radioNone);
            groupBox1.Location = new Point(16, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(87, 146);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Click mode";
            // 
            // radioUpper
            // 
            radioUpper.AutoSize = true;
            radioUpper.Location = new Point(11, 104);
            radioUpper.Name = "radioUpper";
            radioUpper.Size = new Size(57, 19);
            radioUpper.TabIndex = 2;
            radioUpper.Text = "Upper";
            radioUpper.UseVisualStyleBackColor = true;
            // 
            // radioLower
            // 
            radioLower.AutoSize = true;
            radioLower.Location = new Point(11, 68);
            radioLower.Name = "radioLower";
            radioLower.Size = new Size(57, 19);
            radioLower.TabIndex = 1;
            radioLower.Text = "Lower";
            radioLower.UseVisualStyleBackColor = true;
            // 
            // radioNone
            // 
            radioNone.AutoSize = true;
            radioNone.Checked = true;
            radioNone.Location = new Point(11, 29);
            radioNone.Name = "radioNone";
            radioNone.Size = new Size(54, 19);
            radioNone.TabIndex = 0;
            radioNone.TabStop = true;
            radioNone.Text = "None";
            radioNone.UseVisualStyleBackColor = true;
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
            // chkWithE
            // 
            chkWithE.AutoSize = true;
            chkWithE.Location = new Point(21, 249);
            chkWithE.Name = "chkWithE";
            chkWithE.Size = new Size(60, 19);
            chkWithE.TabIndex = 10;
            chkWithE.Text = "With E";
            chkWithE.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 654);
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
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picMask).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Label lblUpper;
        private Label lblLower;
        private PictureBox picMask;
        private SplitContainer splitContainer1;
        private Button button2;
        private GroupBox groupBox1;
        private RadioButton radioUpper;
        private RadioButton radioLower;
        private RadioButton radioNone;
        private Label lblCoords;
        private Label label5;
        private Label label6;
        private TextBox txtInterval;
        private Button button5;
        private CheckBox chkKeepStartPoint;
        private CheckBox chkExitAtNextClick;
        private CheckBox chkWithE;
    }
}
