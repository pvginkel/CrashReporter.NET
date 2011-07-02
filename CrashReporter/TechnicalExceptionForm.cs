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
    internal partial class TechnicalExceptionForm : Form
    {
        public TechnicalExceptionForm()
        {
            InitializeComponent();

            Text = Reporter.Configuration.ApplicationTitle ?? Assembly.GetEntryAssembly().GetName().Name;
            Font = SystemFonts.MessageBoxFont;

            _submitButton.Visible = !Reporter.Configuration.AlwaysSubmit;
        }

        public Exception Exception
        {
            get { return _exceptionControl.Exception; }
            set { _exceptionControl.Exception = value; }
        }

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
