namespace StopWatch
{
    partial class StopWatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.watchLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.formTimer = new System.Windows.Forms.Timer(this.components);
            this.Interval = new System.Windows.Forms.Button();
            this.IntervalLaps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // watchLabel
            // 
            this.watchLabel.AutoSize = true;
            this.watchLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.watchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchLabel.Location = new System.Drawing.Point(122, 58);
            this.watchLabel.Name = "watchLabel";
            this.watchLabel.Size = new System.Drawing.Size(525, 135);
            this.watchLabel.TabIndex = 0;
            this.watchLabel.Text = "00:00.00";
            this.watchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.watchLabel.Click += new System.EventHandler(this.watchLabel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 100);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(537, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 100);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // formTimer
            // 
            this.formTimer.Interval = 10;
            this.formTimer.Tick += new System.EventHandler(this.formTimer_Tick);
            // 
            // Interval
            // 
            this.Interval.Location = new System.Drawing.Point(84, 206);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(158, 70);
            this.Interval.TabIndex = 4;
            this.Interval.Text = "Lap";
            this.Interval.UseVisualStyleBackColor = true;
            this.Interval.Click += new System.EventHandler(this.Interval_Click);
            // 
            // IntervalLaps
            // 
            this.IntervalLaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntervalLaps.Location = new System.Drawing.Point(338, 206);
            this.IntervalLaps.Name = "IntervalLaps";
            this.IntervalLaps.Size = new System.Drawing.Size(364, 59);
            this.IntervalLaps.TabIndex = 5;
            this.IntervalLaps.Text = "00:00.00";
            // 
            // StopWatch
            // 
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(778, 397);
            this.Controls.Add(this.IntervalLaps);
            this.Controls.Add(this.Interval);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.watchLabel);
            this.Name = "StopWatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label watchLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer formTimer;
        private System.Windows.Forms.Button Interval;
        private System.Windows.Forms.Label IntervalLaps;
    }
}

