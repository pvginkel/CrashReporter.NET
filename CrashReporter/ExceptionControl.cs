using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CrashReporter
{
    internal class ExceptionControl : Control
    {
        private const int HorizontalSpacing = 6;
        private const int LeftIndent = 8;

        private Exception _exception;
        private int _count;

        public ExceptionControl()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        public Exception Exception
        {
            get { return _exception; }
            set
            {
                _exception = value;

                if (_exception != null)
                {
                    _count = 1;

                    var exception = _exception.InnerException;

                    while (exception != null)
                    {
                        _count++;
                        exception = exception.InnerException;
                    }
                }

                Size = CalculateSize();

                Invalidate();
            }
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);

            Size = CalculateSize();

            Invalidate();
        }

        private Size CalculateSize()
        {
            if (_exception == null)
            {
                return Size;
            }
            else
            {
                int fontHeight = TextRenderer.MeasureText("w", Font).Height;
                int leftIndent = LeftIndent + Properties.Resources.arrow.Width;
                int currentLeftIndent = 0;

                int runningHeight = 0;

                var exception = _exception;

                while (exception != null)
                {
                    string message = Reporter.FormatException(exception);

                    var size = TextRenderer.MeasureText(
                        message, Font, new Size(Width - currentLeftIndent, int.MaxValue)
                    );

                    runningHeight += size.Height + HorizontalSpacing;

                    currentLeftIndent += leftIndent;

                    exception = exception.InnerException;
                }

                if (_count > 1)
                    runningHeight += fontHeight;

                return new Size(Width, runningHeight);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var arrow = Properties.Resources.arrow;

            int leftIndent = LeftIndent + arrow.Width;
            int currentLeftIndent = 0;

            int runningHeight = 0;
            var exception = _exception;
            bool hadOne = false;

            while (exception != null)
            {
                string message = Reporter.FormatException(exception);

                var size = TextRenderer.MeasureText(
                    message, Font, new Size(Width - currentLeftIndent, int.MaxValue)
                );

                TextRenderer.DrawText(
                    e.Graphics, message, Font,
                    new Rectangle(currentLeftIndent, runningHeight, size.Width, size.Height),
                    ForeColor, BackColor
                );

                int currentRunningHeight = runningHeight;

                runningHeight += size.Height + HorizontalSpacing;

                if (!hadOne)
                {
                    using (var boldFont = new Font(Font, FontStyle.Bold))
                    {
                        int fontHeight = TextRenderer.MeasureText("w", boldFont).Height;

                        TextRenderer.DrawText(
                            e.Graphics, Properties.Resources.AdditionalInformation + ":",
                            boldFont, new Rectangle(currentLeftIndent, runningHeight, Width, fontHeight),
                            ForeColor, BackColor, TextFormatFlags.Left
                        );

                        runningHeight += fontHeight + HorizontalSpacing;
                    }

                    hadOne = true;
                }
                else
                {
                    e.Graphics.DrawImage(
                        arrow, new Point(currentLeftIndent - leftIndent + 4, currentRunningHeight)
                    );
                }

                currentLeftIndent += leftIndent;

                exception = exception.InnerException;
            }
        }
    }
}
