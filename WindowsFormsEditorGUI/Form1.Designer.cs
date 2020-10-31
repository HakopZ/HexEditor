namespace WindowsFormsEditorGUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PathButton = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // PathButton
            // 
            this.PathButton.Location = new System.Drawing.Point(64, 50);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(75, 23);
            this.PathButton.TabIndex = 4;
            this.PathButton.Text = "PathButton";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PathLabel.Location = new System.Drawing.Point(74, 104);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(55, 13);
            this.PathLabel.TabIndex = 5;
            this.PathLabel.Text = "PathLabel";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(64, 134);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 6;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 574);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.PathButton);
            this.Name = "Form1";
            this.Text = "Path";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button PathButton;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Button RunButton;
    }
}

