using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CrashReporter
{
    internal class ExceptionControl : ScrollableControl
    {
        private const int HorizontalSpacing = 6;
        private const int LeftIndent = 8;
        private const TextFormatFlags MessageFormatFlags = TextFormatFlags.Left | TextFormatFlags.NoPrefix | TextFormatFlags.WordBreak;
        private const TextFormatFlags AdditionalInformationFormatFlags = TextFormatFlags.EndEllipsis | TextFormatFlags.Left | TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix;
        private const int MaxCompleteHeight = 600;

        private Exception _exception;
        private int _count;

        public ExceptionControl()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            AutoScroll = true;
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
                        message, Font, new Size(ClientSize.Width - currentLeftIndent, int.MaxValue), MessageFormatFlags
                    );

                    runningHeight += size.Height + HorizontalSpacing;

                    currentLeftIndent += leftIndent;

                    exception = exception.InnerException;
                }

                if (_count > 1)
                    runningHeight += fontHeight;

                AutoScrollMinSize = new Size(0, runningHeight);

                return new Size(Width, Math.Min(MaxCompleteHeight, runningHeight));
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var arrow = Properties.Resources.arrow;

            int leftIndent = LeftIndent + arrow.Width;
            int currentLeftIndent = 0;

            int runningHeight = AutoScrollPosition.Y;
            var exception = _exception;
            bool hadOne = false;

            int fontHeight = TextRenderer.MeasureText("w", Font).Height;

            while (exception != null)
            {
                string message = Reporter.FormatException(exception);

                var size = TextRenderer.MeasureText(
                    message, Font, new Size(ClientSize.Width - currentLeftIndent, int.MaxValue),
                    MessageFormatFlags
                );

                TextRenderer.DrawText(
                    e.Graphics, message, Font,
                    new Rectangle(currentLeftIndent, runningHeight, size.Width, size.Height),
                    ForeColor, BackColor, MessageFormatFlags
                );

                int currentRunningHeight = runningHeight;

                runningHeight += size.Height + HorizontalSpacing;

                if (!hadOne && exception.InnerException != null)
                {
                    using (var boldFont = new Font(Font, FontStyle.Bold))
                    {
                        TextRenderer.DrawText(
                            e.Graphics, Properties.Resources.AdditionalInformation + ":",
                            boldFont, new Rectangle(currentLeftIndent, runningHeight, ClientSize.Width, fontHeight),
                            ForeColor, BackColor, AdditionalInformationFormatFlags
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

            AutoScrollMinSize = new Size(0, runningHeight - AutoScrollPosition.Y);
            Size = new Size(Width, Math.Min(runningHeight - AutoScrollPosition.Y, MaxCompleteHeight));
        }
    }
}
