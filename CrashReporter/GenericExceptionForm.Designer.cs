namespace CrashReporter
{
    partial class GenericExceptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenericExceptionForm));
            this._outerFooterPanel = new System.Windows.Forms.Panel();
            this._footerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._closeButton = new System.Windows.Forms.Button();
            this._submitButton = new System.Windows.Forms.Button();
            this._clientAreaPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._iconPictureBox = new System.Windows.Forms.PictureBox();
            this._stoppedWorkingLabel = new System.Windows.Forms.Label();
            this._subTextLabel = new System.Windows.Forms.Label();
            this._outerFooterPanel.SuspendLayout();
            this._footerPanel.SuspendLayout();
            this._clientAreaPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _outerFooterPanel
            // 
            this._outerFooterPanel.AutoSize = true;
            this._outerFooterPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this._outerFooterPanel.Controls.Add(this._footerPanel);
            this._outerFooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._outerFooterPanel.Location = new System.Drawing.Point(0, 56);
            this._outerFooterPanel.Name = "_outerFooterPanel";
            this._outerFooterPanel.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this._outerFooterPanel.Size = new System.Drawing.Size(385, 40);
            this._outerFooterPanel.TabIndex = 0;
            // 
            // _footerPanel
            // 
            this._footerPanel.AutoSize = true;
            this._footerPanel.BackColor = System.Drawing.SystemColors.Control;
            this._footerPanel.Controls.Add(this._closeButton);
            this._footerPanel.Controls.Add(this._submitButton);
            this._footerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._footerPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this._footerPanel.Location = new System.Drawing.Point(0, 1);
            this._footerPanel.Name = "_footerPanel";
            this._footerPanel.Padding = new System.Windows.Forms.Padding(5);
            this._footerPanel.Size = new System.Drawing.Size(385, 39);
            this._footerPanel.TabIndex = 0;
            // 
            // _closeButton
            // 
            this._closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._closeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._closeButton.Location = new System.Drawing.Point(297, 8);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(75, 23);
            this._closeButton.TabIndex = 1;
            this._closeButton.Text = "Close";
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.Click += new System.EventHandler(this._closeButton_Click);
            // 
            // _submitButton
            // 
            this._submitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._submitButton.Location = new System.Drawing.Point(167, 8);
            this._submitButton.Name = "_submitButton";
            this._submitButton.Size = new System.Drawing.Size(124, 23);
            this._submitButton.TabIndex = 0;
            this._submitButton.Text = "Submit error report";
            this._submitButton.UseVisualStyleBackColor = true;
            this._submitButton.Click += new System.EventHandler(this._submitButton_Click);
            // 
            // _clientAreaPanel
            // 
            this._clientAreaPanel.AutoSize = true;
            this._clientAreaPanel.BackColor = System.Drawing.SystemColors.Window;
            this._clientAreaPanel.Controls.Add(this.tableLayoutPanel1);
            this._clientAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clientAreaPanel.Location = new System.Drawing.Point(0, 0);
            this._clientAreaPanel.Name = "_clientAreaPanel";
            this._clientAreaPanel.Padding = new System.Windows.Forms.Padding(8);
            this._clientAreaPanel.Size = new System.Drawing.Size(385, 56);
            this._clientAreaPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._iconPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._stoppedWorkingLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._subTextLabel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _iconPictureBox
            // 
            this._iconPictureBox.Image = global::CrashReporter.Properties.Resources.error;
            this._iconPictureBox.Location = new System.Drawing.Point(3, 3);
            this._iconPictureBox.Name = "_iconPictureBox";
            this.tableLayoutPanel1.SetRowSpan(this._iconPictureBox, 2);
            this._iconPictureBox.Size = new System.Drawing.Size(32, 32);
            this._iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._iconPictureBox.TabIndex = 0;
            this._iconPictureBox.TabStop = false;
            // 
            // _stoppedWorkingLabel
            // 
            this._stoppedWorkingLabel.AutoSize = true;
            this._stoppedWorkingLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._stoppedWorkingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this._stoppedWorkingLabel.Location = new System.Drawing.Point(41, 0);
            this._stoppedWorkingLabel.Name = "_stoppedWorkingLabel";
            this._stoppedWorkingLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this._stoppedWorkingLabel.Size = new System.Drawing.Size(175, 26);
            this._stoppedWorkingLabel.TabIndex = 1;
            this._stoppedWorkingLabel.Text = "{0} has stopped working";
            // 
            // _subTextLabel
            // 
            this._subTextLabel.AutoSize = true;
            this._subTextLabel.Location = new System.Drawing.Point(41, 26);
            this._subTextLabel.Name = "_subTextLabel";
            this._subTextLabel.Size = new System.Drawing.Size(243, 13);
            this._subTextLabel.TabIndex = 2;
            this._subTextLabel.Text = "You can submit this error to help correct this issue.";
            // 
            // GenericExceptionForm
            // 
            this.AcceptButton = this._submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this._closeButton;
            this.ClientSize = new System.Drawing.Size(385, 96);
            this.Controls.Add(this._clientAreaPanel);
            this.Controls.Add(this._outerFooterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenericExceptionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenericExceptionForm";
            this._outerFooterPanel.ResumeLayout(false);
            this._outerFooterPanel.PerformLayout();
            this._footerPanel.ResumeLayout(false);
            this._clientAreaPanel.ResumeLayout(false);
            this._clientAreaPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._iconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _outerFooterPanel;
        private System.Windows.Forms.FlowLayoutPanel _footerPanel;
        private System.Windows.Forms.Button _closeButton;
        private System.Windows.Forms.Button _submitButton;
        private System.Windows.Forms.Panel _clientAreaPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox _iconPictureBox;
        private System.Windows.Forms.Label _stoppedWorkingLabel;
        private System.Windows.Forms.Label _subTextLabel;
    }
}