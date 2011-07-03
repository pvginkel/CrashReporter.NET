namespace CrashReporterDemo
{
    partial class MainForm
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
            this._throwOtherThreadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._throwSimpleButton = new System.Windows.Forms.Button();
            this._throwNestedButton = new System.Windows.Forms.Button();
            this._reportSimpleButton = new System.Windows.Forms.Button();
            this._largeMessageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _throwOtherThreadButton
            // 
            this._throwOtherThreadButton.Location = new System.Drawing.Point(12, 65);
            this._throwOtherThreadButton.Name = "_throwOtherThreadButton";
            this._throwOtherThreadButton.Size = new System.Drawing.Size(273, 23);
            this._throwOtherThreadButton.TabIndex = 2;
            this._throwOtherThreadButton.Text = "Throw an exception in another thread";
            this._throwOtherThreadButton.UseVisualStyleBackColor = true;
            this._throwOtherThreadButton.Click += new System.EventHandler(this._throwOtherThreadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Review Program.cs for the settings used to submit bugs.";
            // 
            // _throwSimpleButton
            // 
            this._throwSimpleButton.Location = new System.Drawing.Point(12, 36);
            this._throwSimpleButton.Name = "_throwSimpleButton";
            this._throwSimpleButton.Size = new System.Drawing.Size(273, 23);
            this._throwSimpleButton.TabIndex = 4;
            this._throwSimpleButton.Text = "Throw a simple exception";
            this._throwSimpleButton.UseVisualStyleBackColor = true;
            this._throwSimpleButton.Click += new System.EventHandler(this._throwSimpleButton_Click);
            // 
            // _throwNestedButton
            // 
            this._throwNestedButton.Location = new System.Drawing.Point(12, 94);
            this._throwNestedButton.Name = "_throwNestedButton";
            this._throwNestedButton.Size = new System.Drawing.Size(273, 23);
            this._throwNestedButton.TabIndex = 5;
            this._throwNestedButton.Text = "Throw an exception with nesting";
            this._throwNestedButton.UseVisualStyleBackColor = true;
            this._throwNestedButton.Click += new System.EventHandler(this._throwNestedButton_Click);
            // 
            // _reportSimpleButton
            // 
            this._reportSimpleButton.Location = new System.Drawing.Point(12, 123);
            this._reportSimpleButton.Name = "_reportSimpleButton";
            this._reportSimpleButton.Size = new System.Drawing.Size(273, 23);
            this._reportSimpleButton.TabIndex = 6;
            this._reportSimpleButton.Text = "Report a simple exception (doesn\'t exit)";
            this._reportSimpleButton.UseVisualStyleBackColor = true;
            this._reportSimpleButton.Click += new System.EventHandler(this._reportSimpleButton_Click);
            // 
            // _largeMessageButton
            // 
            this._largeMessageButton.Location = new System.Drawing.Point(12, 153);
            this._largeMessageButton.Name = "_largeMessageButton";
            this._largeMessageButton.Size = new System.Drawing.Size(273, 23);
            this._largeMessageButton.TabIndex = 7;
            this._largeMessageButton.Text = "Report an exception with a large message";
            this._largeMessageButton.UseVisualStyleBackColor = true;
            this._largeMessageButton.Click += new System.EventHandler(this._largeMessageButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 187);
            this.Controls.Add(this._largeMessageButton);
            this.Controls.Add(this._reportSimpleButton);
            this.Controls.Add(this._throwNestedButton);
            this.Controls.Add(this._throwSimpleButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._throwOtherThreadButton);
            this.Name = "MainForm";
            this.Text = "CrashReporter Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _throwOtherThreadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _throwSimpleButton;
        private System.Windows.Forms.Button _throwNestedButton;
        private System.Windows.Forms.Button _reportSimpleButton;
        private System.Windows.Forms.Button _largeMessageButton;
    }
}

