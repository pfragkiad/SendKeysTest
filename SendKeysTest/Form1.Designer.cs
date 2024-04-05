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
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            numSwipe = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            numUp = new NumericUpDown();
            numDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numSwipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDown).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(33, 143);
            button1.Name = "button1";
            button1.Size = new Size(207, 61);
            button1.TabIndex = 0;
            button1.Text = "HACK ROBLOX!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 10000;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 28);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 2;
            label1.Text = "Swipe interval [s]:";
            // 
            // numSwipe
            // 
            numSwipe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numSwipe.Location = new Point(161, 26);
            numSwipe.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSwipe.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numSwipe.Name = "numSwipe";
            numSwipe.Size = new Size(79, 23);
            numSwipe.TabIndex = 3;
            numSwipe.TextAlign = HorizontalAlignment.Right;
            numSwipe.Value = new decimal(new int[] { 60, 0, 0, 0 });
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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 229);
            Controls.Add(numDown);
            Controls.Add(numUp);
            Controls.Add(numSwipe);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Wolf Roblox";
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)numSwipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private NumericUpDown numSwipe;
        private Label label2;
        private Label label3;
        private NumericUpDown numUp;
        private NumericUpDown numDown;
    }
}
