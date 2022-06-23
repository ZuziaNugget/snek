namespace snek
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.CorrectButton = new System.Windows.Forms.Button();
            this.FalseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CorrectButton
            // 
            this.CorrectButton.Location = new System.Drawing.Point(172, 271);
            this.CorrectButton.Name = "CorrectButton";
            this.CorrectButton.Size = new System.Drawing.Size(172, 94);
            this.CorrectButton.TabIndex = 1;
            this.CorrectButton.Tag = "1";
            this.CorrectButton.Text = "Correct";
            this.CorrectButton.UseVisualStyleBackColor = true;
            this.CorrectButton.Click += new System.EventHandler(this.CorrectButton_Click);
            // 
            // FalseButton
            // 
            this.FalseButton.Location = new System.Drawing.Point(454, 271);
            this.FalseButton.Name = "FalseButton";
            this.FalseButton.Size = new System.Drawing.Size(172, 94);
            this.FalseButton.TabIndex = 2;
            this.FalseButton.Tag = "2";
            this.FalseButton.Text = "False";
            this.FalseButton.UseVisualStyleBackColor = true;
            this.FalseButton.Click += new System.EventHandler(this.FalseButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FalseButton);
            this.Controls.Add(this.CorrectButton);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CorrectButton;
        private System.Windows.Forms.Button FalseButton;
    }
}