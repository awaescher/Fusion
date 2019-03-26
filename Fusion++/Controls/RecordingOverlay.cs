using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FusionPlusPlus.Controls
{
    public partial class RecordingOverlay : UserControl
    {
        public event EventHandler StopRequested;

        private DateTime _timerStarted;
        private Timer _timer;

        public RecordingOverlay()
        {
            InitializeComponent();
        }

        public static RecordingOverlay PutOn(Control parent)
        {
            var overlay = new RecordingOverlay();

            overlay.Parent = parent;
            parent.Controls.Add(overlay);

            overlay.Dock = DockStyle.Fill;

            return overlay;
        }

        public void StartTimer()
        {
            _timerStarted = DateTime.Now;
            WriteElapsedTime(TimeSpan.Zero);

			if (_timer == null)
            {
                _timer = new Timer() { Interval = 1000 };
                _timer.Tick += (s, e) => WriteElapsedTime(DateTime.Now - _timerStarted);
            }

            _timer.Start();
            lblStop.Show();
        }

        public void StopTimer()
        {
            WriteElapsedTime(TimeSpan.Zero);
            _timer?.Stop();
            lblStop.Hide();
        }

        private void WriteElapsedTime(TimeSpan span)
        {
            lblDuration.Text = span.ToString("hh\\:mm\\:ss");
        }

        public void Remove()
        {
            Parent.Controls.Remove(this);
        }

        private void LblStop_Click(object sender, EventArgs e)
        {
            StopRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
