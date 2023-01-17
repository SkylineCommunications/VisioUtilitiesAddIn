namespace TestVisioAddIn
{
    partial class ReplaceText
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
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.ReplaceTextBox = new System.Windows.Forms.TextBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.ReplaceLabel = new System.Windows.Forms.Label();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(166, 33);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(311, 29);
            this.FindTextBox.TabIndex = 0;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // ReplaceTextBox
            // 
            this.ReplaceTextBox.Location = new System.Drawing.Point(166, 111);
            this.ReplaceTextBox.Name = "ReplaceTextBox";
            this.ReplaceTextBox.Size = new System.Drawing.Size(311, 29);
            this.ReplaceTextBox.TabIndex = 1;
            this.ReplaceTextBox.TextChanged += new System.EventHandler(this.ReplaceTextBox_TextChanged);
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(40, 33);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(50, 25);
            this.FindLabel.TabIndex = 2;
            this.FindLabel.Text = "Find";
            this.FindLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReplaceLabel
            // 
            this.ReplaceLabel.AutoSize = true;
            this.ReplaceLabel.Location = new System.Drawing.Point(40, 115);
            this.ReplaceLabel.Name = "ReplaceLabel";
            this.ReplaceLabel.Size = new System.Drawing.Size(83, 25);
            this.ReplaceLabel.TabIndex = 3;
            this.ReplaceLabel.Text = "Replace";
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Location = new System.Drawing.Point(166, 198);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(100, 44);
            this.ReplaceButton.TabIndex = 4;
            this.ReplaceButton.Text = "Replace";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.replace_Click);
            // 
            // ReplaceText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 269);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.ReplaceLabel);
            this.Controls.Add(this.FindLabel);
            this.Controls.Add(this.ReplaceTextBox);
            this.Controls.Add(this.FindTextBox);
            this.Name = "ReplaceText";
            this.Text = "Replace Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.TextBox ReplaceTextBox;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.Label ReplaceLabel;
        private System.Windows.Forms.Button ReplaceButton;
    }
}