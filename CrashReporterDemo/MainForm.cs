using System;
using System.Threading;
using System.Windows.Forms;
using CrashReporter;
using CrashReporterTest;
using CrashReporterTest.Properties;

namespace CrashReporterDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void _throwOtherThreadButton_Click(object sender, EventArgs e)
        {
            var thread = new Thread(new ThreadStart(() =>
            {
                int i = 0;

                int j = 1 / i;
            }));
            
            thread.Start();
        }

        private void _throwSimpleButton_Click(object sender, EventArgs e)
        {
            int i = 0;

            int j = 1 / i;
        }

        private void _throwNestedButton_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;

                int j = 1 / i;
            }
            catch (Exception ex)
            {
                throw new SomeOperationFailedException("Some operation has failed", ex);
            }
        }

        private void _reportSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;

                int j = 1 / i;
            }
            catch (Exception ex)
            {
                Reporter.Report(ex);
            }
        }

        private void _largeMessageButton_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    // Throw an exception with a really really long text.

                    throw new Exception(Resources.LoremIpsum);
                }
                catch (Exception ex)
                {
                    throw new SomeOperationFailedException(
                        "Some operation has failed.\n\nThe inner exception will show more details concerning the reasion this operation has failed.\n", ex
                    );
                }
            }
            catch (Exception ex)
            {
                Reporter.Report(ex);
            }
        }
    }
}
