namespace NNMehmet
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
            this.EmptyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmptyButton
            // 
            this.EmptyButton.Location = new System.Drawing.Point(156, 251);
            this.EmptyButton.Name = "EmptyButton";
            this.EmptyButton.Size = new System.Drawing.Size(75, 23);
            this.EmptyButton.TabIndex = 0;
            this.EmptyButton.UseVisualStyleBackColor = true;
            this.EmptyButton.Click += new System.EventHandler(this.EmptyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 312);
            this.Controls.Add(this.EmptyButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmptyButton;
    }
}

