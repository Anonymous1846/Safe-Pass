namespace SafePass
{
    partial class UpdateUserPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUserPass));
            this.closeBtnForUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updateBtnuser = new System.Windows.Forms.Button();
            this.nicknameUpdate = new System.Windows.Forms.TextBox();
            this.emailUpdate = new System.Windows.Forms.TextBox();
            this.passUpdate = new System.Windows.Forms.TextBox();
            this.lastUpdationPassword = new System.Windows.Forms.Label();
            this.togglePass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBtnForUpdate
            // 
            this.closeBtnForUpdate.FlatAppearance.BorderSize = 0;
            this.closeBtnForUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtnForUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtnForUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeBtnForUpdate.Location = new System.Drawing.Point(747, 1);
            this.closeBtnForUpdate.Name = "closeBtnForUpdate";
            this.closeBtnForUpdate.Size = new System.Drawing.Size(52, 47);
            this.closeBtnForUpdate.TabIndex = 0;
            this.closeBtnForUpdate.Text = "X";
            this.closeBtnForUpdate.UseVisualStyleBackColor = true;
            this.closeBtnForUpdate.Click += new System.EventHandler(this.closeBtnForUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update User Password Infomation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nickname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email/Username :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password :";
            // 
            // updateBtnuser
            // 
            this.updateBtnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtnuser.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.updateBtnuser.ForeColor = System.Drawing.Color.White;
            this.updateBtnuser.Location = new System.Drawing.Point(20, 248);
            this.updateBtnuser.Name = "updateBtnuser";
            this.updateBtnuser.Size = new System.Drawing.Size(95, 40);
            this.updateBtnuser.TabIndex = 5;
            this.updateBtnuser.Text = "Update";
            this.updateBtnuser.UseVisualStyleBackColor = true;
            this.updateBtnuser.Click += new System.EventHandler(this.updateBtnuser_Click);
            this.updateBtnuser.MouseEnter += new System.EventHandler(this.updateBtnuser_MouseEnter);
            this.updateBtnuser.MouseLeave += new System.EventHandler(this.updateBtnuser_MouseLeave);
            // 
            // nicknameUpdate
            // 
            this.nicknameUpdate.Location = new System.Drawing.Point(210, 68);
            this.nicknameUpdate.Name = "nicknameUpdate";
            this.nicknameUpdate.Size = new System.Drawing.Size(428, 22);
            this.nicknameUpdate.TabIndex = 6;
            // 
            // emailUpdate
            // 
            this.emailUpdate.Location = new System.Drawing.Point(210, 125);
            this.emailUpdate.Name = "emailUpdate";
            this.emailUpdate.Size = new System.Drawing.Size(428, 22);
            this.emailUpdate.TabIndex = 7;
            // 
            // passUpdate
            // 
            this.passUpdate.Location = new System.Drawing.Point(210, 182);
            this.passUpdate.Name = "passUpdate";
            this.passUpdate.PasswordChar = '*';
            this.passUpdate.Size = new System.Drawing.Size(428, 22);
            this.passUpdate.TabIndex = 8;
            // 
            // lastUpdationPassword
            // 
            this.lastUpdationPassword.AutoSize = true;
            this.lastUpdationPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastUpdationPassword.ForeColor = System.Drawing.Color.White;
            this.lastUpdationPassword.Location = new System.Drawing.Point(210, 234);
            this.lastUpdationPassword.Name = "lastUpdationPassword";
            this.lastUpdationPassword.Size = new System.Drawing.Size(38, 18);
            this.lastUpdationPassword.TabIndex = 9;
            this.lastUpdationPassword.Text = "Last ";
            // 
            // togglePass
            // 
            this.togglePass.AutoSize = true;
            this.togglePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.togglePass.ForeColor = System.Drawing.Color.Aqua;
            this.togglePass.Location = new System.Drawing.Point(666, 186);
            this.togglePass.Name = "togglePass";
            this.togglePass.Size = new System.Drawing.Size(58, 17);
            this.togglePass.TabIndex = 10;
            this.togglePass.Text = "Toggle";
            this.togglePass.Click += new System.EventHandler(this.togglePass_Click);
            // 
            // UpdateUserPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.togglePass);
            this.Controls.Add(this.lastUpdationPassword);
            this.Controls.Add(this.passUpdate);
            this.Controls.Add(this.emailUpdate);
            this.Controls.Add(this.nicknameUpdate);
            this.Controls.Add(this.updateBtnuser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtnForUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateUserPass";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.UpdateUserPass_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpdateUserPass_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdateUserPass_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpdateUserPass_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtnForUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updateBtnuser;
        private System.Windows.Forms.TextBox nicknameUpdate;
        private System.Windows.Forms.TextBox emailUpdate;
        private System.Windows.Forms.TextBox passUpdate;
        private System.Windows.Forms.Label lastUpdationPassword;
        private System.Windows.Forms.Label togglePass;
    }
}