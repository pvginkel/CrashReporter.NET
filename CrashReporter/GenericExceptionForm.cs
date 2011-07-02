using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace CrashReporter
{
    internal partial class GenericExceptionForm : Form
    {
        public GenericExceptionForm()
        {
            InitializeComponent();

            Text = Reporter.Configuration.ApplicationTitle ?? Assembly.GetEntryAssembly().GetName().Name;
            Font = SystemFonts.MessageBoxFont;

            _stoppedWorkingLabel.Text = String.Format(_stoppedWorkingLabel.Text, Text);

            _submitButton.Visible = !Reporter.Configuration.AlwaysSubmit;
        }

        public Exception Exception { get; set; }

        private void _submitButton_Click(object sender, EventArgs e)
        {
            Reporter.SendReport(this, Exception);

            DialogResult = DialogResult.OK;
        }

        private void _closeButton_Click(object sender, EventArgs e)
        {
            if (Reporter.Configuration.AlwaysSubmit)
            {
                Reporter.SendReport(this, Exception);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
