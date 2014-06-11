namespace SimpleLogin
{
    partial class HomeView
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
            this.lblLoginMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoginMessage
            // 
            this.lblLoginMessage.AutoSize = true;
            this.lblLoginMessage.Location = new System.Drawing.Point(83, 98);
            this.lblLoginMessage.Name = "lblLoginMessage";
            this.lblLoginMessage.Size = new System.Drawing.Size(162, 13);
            this.lblLoginMessage.TabIndex = 0;
            this.lblLoginMessage.Text = "You have successfully logged in.";
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblLoginMessage);
            this.Name = "HomeView";
            this.Text = "HomeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginMessage;
    }
}