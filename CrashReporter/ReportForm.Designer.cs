namespace CrashReporter
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._reportDetailsPanel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._commentsPanel = new System.Windows.Forms.TableLayoutPanel();
            this._commentsLabel = new System.Windows.Forms.Label();
            this._commentsTextBox = new System.Windows.Forms.TextBox();
            this._emailPanel = new System.Windows.Forms.TableLayoutPanel();
            this._emailAddressLabel = new System.Windows.Forms.Label();
            this._emailTextBox = new System.Windows.Forms.TextBox();
            this._buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._acceptButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this._reportDetailsPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this._commentsPanel.SuspendLayout();
            this._emailPanel.SuspendLayout();
            this._buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._reportDetailsPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._buttonsPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 240);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _reportDetailsPanel
            // 
            this._reportDetailsPanel.AutoSize = true;
            this._reportDetailsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._reportDetailsPanel.Controls.Add(this.tableLayoutPanel2);
            this._reportDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._reportDetailsPanel.Location = new System.Drawing.Point(3, 3);
            this._reportDetailsPanel.Name = "_reportDetailsPanel";
            this._reportDetailsPanel.Padding = new System.Windows.Forms.Padding(8);
            this._reportDetailsPanel.Size = new System.Drawing.Size(397, 205);
            this._reportDetailsPanel.TabIndex = 1;
            this._reportDetailsPanel.TabStop = false;
            this._reportDetailsPanel.Text = "Error report details";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this._commentsPanel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this._emailPanel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(381, 176);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // _commentsPanel
            // 
            this._commentsPanel.AutoSize = true;
            this._commentsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._commentsPanel.ColumnCount = 1;
            this._commentsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._commentsPanel.Controls.Add(this._commentsLabel, 0, 0);
            this._commentsPanel.Controls.Add(this._commentsTextBox, 0, 1);
            this._commentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._commentsPanel.Location = new System.Drawing.Point(0, 39);
            this._commentsPanel.Margin = new System.Windows.Forms.Padding(0);
            this._commentsPanel.Name = "_commentsPanel";
            this._commentsPanel.RowCount = 2;
            this._commentsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._commentsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._commentsPanel.Size = new System.Drawing.Size(381, 137);
            this._commentsPanel.TabIndex = 3;
            // 
            // _commentsLabel
            // 
            this._commentsLabel.AutoSize = true;
            this._commentsLabel.Location = new System.Drawing.Point(3, 0);
            this._commentsLabel.Name = "_commentsLabel";
            this._commentsLabel.Size = new System.Drawing.Size(59, 13);
            this._commentsLabel.TabIndex = 0;
            this._commentsLabel.Text = "Comments:";
            // 
            // _commentsTextBox
            // 
            this._commentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._commentsTextBox.Location = new System.Drawing.Point(3, 16);
            this._commentsTextBox.Multiline = true;
            this._commentsTextBox.Name = "_commentsTextBox";
            this._commentsTextBox.Size = new System.Drawing.Size(375, 118);
            this._commentsTextBox.TabIndex = 1;
            // 
            // _emailPanel
            // 
            this._emailPanel.AutoSize = true;
            this._emailPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._emailPanel.ColumnCount = 1;
            this._emailPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._emailPanel.Controls.Add(this._emailAddressLabel, 0, 0);
            this._emailPanel.Controls.Add(this._emailTextBox, 0, 1);
            this._emailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._emailPanel.Location = new System.Drawing.Point(0, 0);
            this._emailPanel.Margin = new System.Windows.Forms.Padding(0);
            this._emailPanel.Name = "_emailPanel";
            this._emailPanel.RowCount = 2;
            this._emailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._emailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._emailPanel.Size = new System.Drawing.Size(381, 39);
            this._emailPanel.TabIndex = 2;
            // 
            // _emailAddressLabel
            // 
            this._emailAddressLabel.AutoSize = true;
            this._emailAddressLabel.Location = new System.Drawing.Point(3, 0);
            this._emailAddressLabel.Name = "_emailAddressLabel";
            this._emailAddressLabel.Size = new System.Drawing.Size(78, 13);
            this._emailAddressLabel.TabIndex = 0;
            this._emailAddressLabel.Text = "E-mail address:";
            // 
            // _emailTextBox
            // 
            this._emailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._emailTextBox.Location = new System.Drawing.Point(3, 16);
            this._emailTextBox.Name = "_emailTextBox";
            this._emailTextBox.Size = new System.Drawing.Size(375, 20);
            this._emailTextBox.TabIndex = 1;
            // 
            // _buttonsPanel
            // 
            this._buttonsPanel.AutoSize = true;
            this._buttonsPanel.Controls.Add(this._acceptButton);
            this._buttonsPanel.Controls.Add(this._cancelButton);
            this._buttonsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this._buttonsPanel.Location = new System.Drawing.Point(241, 211);
            this._buttonsPanel.Margin = new System.Windows.Forms.Padding(0);
            this._buttonsPanel.Name = "_buttonsPanel";
            this._buttonsPanel.Size = new System.Drawing.Size(162, 29);
            this._buttonsPanel.TabIndex = 0;
            // 
            // _acceptButton
            // 
            this._acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._acceptButton.Location = new System.Drawing.Point(3, 3);
            this._acceptButton.Name = "_acceptButton";
            this._acceptButton.Size = new System.Drawing.Size(75, 23);
            this._acceptButton.TabIndex = 0;
            this._acceptButton.Text = "Send";
            this._acceptButton.UseVisualStyleBackColor = true;
            this._acceptButton.Click += new System.EventHandler(this._acceptButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._cancelButton.Location = new System.Drawing.Point(84, 3);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // ReportForm
            // 
            this.AcceptButton = this._acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(419, 256);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Submit Error Report";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this._reportDetailsPanel.ResumeLayout(false);
            this._reportDetailsPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this._commentsPanel.ResumeLayout(false);
            this._commentsPanel.PerformLayout();
            this._emailPanel.ResumeLayout(false);
            this._emailPanel.PerformLayout();
            this._buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel _buttonsPanel;
        private System.Windows.Forms.Button _acceptButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.GroupBox _reportDetailsPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel _commentsPanel;
        private System.Windows.Forms.Label _commentsLabel;
        private System.Windows.Forms.TextBox _commentsTextBox;
        private System.Windows.Forms.TableLayoutPanel _emailPanel;
        private System.Windows.Forms.Label _emailAddressLabel;
        private System.Windows.Forms.TextBox _emailTextBox;
    }
}