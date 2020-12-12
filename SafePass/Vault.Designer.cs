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
            this.searchNickName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toggle = new System.Windows.Forms.DataGridViewLinkColumn();
            this.copy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addPassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // searchNickName
            // 
            this.searchNickName.Location = new System.Drawing.Point(214, 92);
            this.searchNickName.Name = "searchNickName";
            this.searchNickName.Size = new System.Drawing.Size(245, 22);
            this.searchNickName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Nickname :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(30, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 345);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nickname,
            this.Username_Email,
            this.Password,
            this.toggle,
            this.copy});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(677, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // nickname
            // 
            this.nickname.HeaderText = "Nick Name";
            this.nickname.MinimumWidth = 6;
            this.nickname.Name = "nickname";
            this.nickname.Width = 125;
            // 
            // Username_Email
            // 
            this.Username_Email.HeaderText = "Username/Email";
            this.Username_Email.MinimumWidth = 6;
            this.Username_Email.Name = "Username_Email";
            this.Username_Email.Width = 125;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 125;
            // 
            // toggle
            // 
            this.toggle.HeaderText = "toggle";
            this.toggle.MinimumWidth = 6;
            this.toggle.Name = "toggle";
            this.toggle.Width = 125;
            // 
            // copy
            // 
            this.copy.HeaderText = "Copy";
            this.copy.MinimumWidth = 6;
            this.copy.Name = "copy";
            this.copy.Width = 125;
            // 
            // addPassword
            // 
            this.addPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPassword.ForeColor = System.Drawing.Color.White;
            this.addPassword.Location = new System.Drawing.Point(214, 133);
            this.addPassword.Name = "addPassword";
            this.addPassword.Size = new System.Drawing.Size(86, 26);
            this.addPassword.TabIndex = 4;
            this.addPassword.Text = "Add";
            this.addPassword.UseVisualStyleBackColor = true;
            this.addPassword.Click += new System.EventHandler(this.addPassword_Click);
            // 
            // Vault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.addPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchNickName);
            this.Controls.Add(this.usernameForVault);
            this.Name = "Vault";
            this.Size = new System.Drawing.Size(730, 555);
            this.Load += new System.EventHandler(this.Vault_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameForVault;
        private System.Windows.Forms.TextBox searchNickName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewLinkColumn toggle;
        private System.Windows.Forms.DataGridViewButtonColumn copy;
        private System.Windows.Forms.Button addPassword;
    }
}
