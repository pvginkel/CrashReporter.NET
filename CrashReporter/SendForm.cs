using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CrashReporter
{
    internal partial class SendForm : Form
    {
        public SendForm()
        {
            InitializeComponent();
        }

        public void UpdateProgress(string label, int value, int count)
        {
            if (InvokeRequired)
            {
                Invoke(new ProgressCallback(UpdateProgress), label, value, count);
            }
            else
            {
                _progressLabel.Text = label;
                _progressBar.Maximum = count;
                _progressBar.Value = value;
            }
        }
    }

    internal delegate void ProgressCallback(string label, int value, int count);
}
