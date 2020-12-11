namespace SafePass
{
    partial class EdituserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdituserProfile));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmPasswordEditUpdate = new System.Windows.Forms.TextBox();
            this.passwordEditUpdate = new System.Windows.Forms.TextBox();
            this.emailEditUpdate = new System.Windows.Forms.TextBox();
            this.userEditProfileLabel = new System.Windows.Forms.Label();
            this.upBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.closeEdit = new System.Windows.Forms.Button();
            this.showPass = new System.Windows.Forms.LinkLabel();
            this.showConfirm = new System.Windows.Forms.LinkLabel();
            this.passwordsDontMatchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password :";
            // 
            // confirmPasswordEditUpdate
            // 
            this.confirmPasswordEditUpdate.Location = new System.Drawing.Point(186, 177);
            this.confirmPasswordEditUpdate.Name = "confirmPasswordEditUpdate";
            this.confirmPasswordEditUpdate.PasswordChar = '*';
            this.confirmPasswordEditUpdate.Size = new System.Drawing.Size(360, 22);
            this.confirmPasswordEditUpdate.TabIndex = 3;
            this.confirmPasswordEditUpdate.TextChanged += new System.EventHandler(this.confirmPasswordEditUpdate_TextChanged);
            // 
            // passwordEditUpdate
            // 
            this.passwordEditUpdate.Location = new System.Drawing.Point(186, 126);
            this.passwordEditUpdate.Name = "passwordEditUpdate";
            this.passwordEditUpdate.PasswordChar = '*';
            this.passwordEditUpdate.Size = new System.Drawing.Size(360, 22);
            this.passwordEditUpdate.TabIndex = 4;
            this.passwordEditUpdate.TextChanged += new System.EventHandler(this.passwordEditUpdate_TextChanged);
            // 
            // emailEditUpdate
            // 
            this.emailEditUpdate.Location = new System.Drawing.Point(186, 78);
            this.emailEditUpdate.Name = "emailEditUpdate";
            this.emailEditUpdate.Size = new System.Drawing.Size(360, 22);
            this.emailEditUpdate.TabIndex = 5;
            // 
            // userEditProfileLabel
            // 
            this.userEditProfileLabel.AutoSize = true;
            this.userEditProfileLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEditProfileLabel.ForeColor = System.Drawing.Color.White;
            this.userEditProfileLabel.Location = new System.Drawing.Point(25, 13);
            this.userEditProfileLabel.Name = "userEditProfileLabel";
            this.userEditProfileLabel.Size = new System.Drawing.Size(164, 26);
            this.userEditProfileLabel.TabIndex = 6;
            this.userEditProfileLabel.Text = "user Edit Profile";
            // 
            // upBtn
            // 
            this.upBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.upBtn.ForeColor = System.Drawing.Color.White;
            this.upBtn.Location = new System.Drawing.Point(186, 244);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(89, 32);
            this.upBtn.TabIndex = 7;
            this.upBtn.Text = "Update ";
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            this.upBtn.MouseEnter += new System.EventHandler(this.upBtn_MouseEnter);
            this.upBtn.MouseLeave += new System.EventHandler(this.upBtn_MouseLeave);
            // 
            // delBtn
            // 
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.delBtn.ForeColor = System.Drawing.Color.White;
            this.delBtn.Location = new System.Drawing.Point(308, 244);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(91, 32);
            this.delBtn.TabIndex = 8;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            this.delBtn.MouseEnter += new System.EventHandler(this.delBtn_MouseEnter);
            this.delBtn.MouseLeave += new System.EventHandler(this.delBtn_MouseLeave);
            // 
            // closeEdit
            // 
            this.closeEdit.FlatAppearance.BorderSize = 0;
            this.closeEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeEdit.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeEdit.Location = new System.Drawing.Point(693, 0);
            this.closeEdit.Name = "closeEdit";
            this.closeEdit.Size = new System.Drawing.Size(41, 40);
            this.closeEdit.TabIndex = 9;
            this.closeEdit.Text = "x";
            this.closeEdit.UseVisualStyleBackColor = true;
            this.closeEdit.Click += new System.EventHandler(this.closeEdit_Click);
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Location = new System.Drawing.Point(566, 130);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(42, 17);
            this.showPass.TabIndex = 10;
            this.showPass.TabStop = true;
            this.showPass.Text = "Show";
            this.showPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.showPass_LinkClicked);
            // 
            // showConfirm
            // 
            this.showConfirm.AutoSize = true;
            this.showConfirm.Location = new System.Drawing.Point(566, 181);
            this.showConfirm.Name = "showConfirm";
            this.showConfirm.Size = new System.Drawing.Size(42, 17);
            this.showConfirm.TabIndex = 11;
            this.showConfirm.TabStop = true;
            this.showConfirm.Text = "Show";
            this.showConfirm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.showConfirm_LinkClicked);
            // 
            // passwordsDontMatchLabel
            // 
            this.passwordsDontMatchLabel.AutoSize = true;
            this.passwordsDontMatchLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordsDontMatchLabel.Location = new System.Drawing.Point(187, 212);
            this.passwordsDontMatchLabel.Name = "passwordsDontMatchLabel";
            this.passwordsDontMatchLabel.Size = new System.Drawing.Size(0, 17);
            this.passwordsDontMatchLabel.TabIndex = 12;
            this.passwordsDontMatchLabel.Visible = false;
            // 
            // EdituserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.passwordsDontMatchLabel);
            this.Controls.Add(this.showConfirm);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.closeEdit);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.upBtn);
            this.Controls.Add(this.userEditProfileLabel);
            this.Controls.Add(this.emailEditUpdate);
            this.Controls.Add(this.passwordEditUpdate);
            this.Controls.Add(this.confirmPasswordEditUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EdituserProfile";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.EdituserProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmPasswordEditUpdate;
        private System.Windows.Forms.TextBox passwordEditUpdate;
        private System.Windows.Forms.TextBox emailEditUpdate;
        private System.Windows.Forms.Label userEditProfileLabel;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button closeEdit;
        private System.Windows.Forms.LinkLabel showPass;
        private System.Windows.Forms.LinkLabel showConfirm;
        private System.Windows.Forms.Label passwordsDontMatchLabel;
    }
}