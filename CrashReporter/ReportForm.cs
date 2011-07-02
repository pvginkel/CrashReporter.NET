using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CrashReporter
{
    internal partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();

            Font = SystemFonts.MessageBoxFont;

            _emailPanel.Visible = Reporter.Configuration.AllowEmailAddress;
            _commentsPanel.Visible = Reporter.Configuration.AllowComments;

            using (var key = Reporter.BaseKey)
            {
                _emailTextBox.Text = (string)key.GetValue(Reporter.KeyEmailAddress);
            }
        }

        public Exception Exception { get; set; }

        private void _acceptButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_emailTextBox.Text))
            {
                using (var key = Reporter.BaseKey)
                {
                    key.SetValue(Reporter.KeyEmailAddress, _emailTextBox.Text);
                }
            }

            Reporter.SubmitException(this, Exception, _emailTextBox.Text, _commentsTextBox.Text);

            DialogResult = DialogResult.OK;
        }
    }
}
