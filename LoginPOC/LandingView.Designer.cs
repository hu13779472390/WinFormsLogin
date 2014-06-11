namespace LoginPOC
{
    partial class LandingView
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
            this.lblLandingViewMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLandingViewMessage
            // 
            this.lblLandingViewMessage.AutoSize = true;
            this.lblLandingViewMessage.Location = new System.Drawing.Point(55, 82);
            this.lblLandingViewMessage.Name = "lblLandingViewMessage";
            this.lblLandingViewMessage.Size = new System.Drawing.Size(117, 13);
            this.lblLandingViewMessage.TabIndex = 0;
            this.lblLandingViewMessage.Text = "Successfully Logged In";
            this.lblLandingViewMessage.Click += new System.EventHandler(this.lblLandingViewMessage_Click);
            // 
            // LandingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblLandingViewMessage);
            this.Name = "LandingView";
            this.Text = "LandingView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLandingViewMessage;
    }
}