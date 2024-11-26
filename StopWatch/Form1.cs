using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class StopWatch : Form
    {
        private DateTime startTime;
        private TimeSpan elapsedTime = TimeSpan.Zero;
        private List<TimeSpan> lapTimes = new List<TimeSpan>();

        public StopWatch()
        {
            InitializeComponent();
        }

        private void watchLabel_Click(object sender, EventArgs e)
        {
        }

        // Start Button
        private void button1_Click(object sender, EventArgs e)
        {
            // Start the timer
            startTime = DateTime.Now - elapsedTime;
            formTimer.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Stop the timer and save the elapsed time
            formTimer.Stop();
            elapsedTime = DateTime.Now - startTime;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Reset the timer
            formTimer.Stop();
            watchLabel.Text = "00:00.00";
            IntervalLaps.Text = "00:00.00";
            elapsedTime = TimeSpan.Zero;
            lapTimes.Clear();
        }


        // Timer Tick Event
        private void formTimer_Tick(object sender, EventArgs e)
        {
            // Calculate elapsed time since start
            TimeSpan span = DateTime.Now - startTime;
            watchLabel.Text = span.ToString(@"mm\:ss\.ff");
        }

        // Lap Button
        private void buttonLap_Click(object sender, EventArgs e)
        {
            // Capture current elapsed time as a lap time
            TimeSpan currentLapTime = DateTime.Now - startTime;
            lapTimes.Add(currentLapTime);

            // Display the latest lap time in label2
            IntervalLaps.Text = currentLapTime.ToString(@"mm\:ss\.ff");
        }

        private void Interval_Click(object sender, EventArgs e)
        {
            // Capture current elapsed time as a lap time
            TimeSpan currentLapTime = DateTime.Now - startTime;

            // Display the latest lap time in label2
            IntervalLaps.Text = currentLapTime.ToString(@"mm\:ss\.ff");
        }
    }
}
