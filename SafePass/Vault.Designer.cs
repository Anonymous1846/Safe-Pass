namespace SafePass
{
    partial class Vault
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameForVault = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameForVault
            // 
            this.usernameForVault.AutoSize = true;
            this.usernameForVault.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameForVault.ForeColor = System.Drawing.Color.White;
            this.usernameForVault.Location = new System.Drawing.Point(47, 25);
            this.usernameForVault.Name = "usernameForVault";
            this.usernameForVault.Size = new System.Drawing.Size(205, 26);
            this.usernameForVault.TabIndex = 0;
            this.usernameForVault.Text = "User Password Vault";
            // 
            // Vault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.usernameForVault);
            this.Name = "Vault";
            this.Size = new System.Drawing.Size(730, 555);
            this.Load += new System.EventHandler(this.Vault_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameForVault;
    }
}
