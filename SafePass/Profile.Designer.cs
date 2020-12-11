namespace SafePass
{
    partial class Profile
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
            this.components = new System.ComponentModel.Container();
            this.userProfileInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastUpdate = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.currTime = new System.Windows.Forms.Label();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // userProfileInfo
            // 
            this.userProfileInfo.AutoSize = true;
            this.userProfileInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userProfileInfo.ForeColor = System.Drawing.Color.White;
            this.userProfileInfo.Location = new System.Drawing.Point(48, 24);
            this.userProfileInfo.Name = "userProfileInfo";
            this.userProfileInfo.Size = new System.Drawing.Size(17, 26);
            this.userProfileInfo.TabIndex = 0;
            this.userProfileInfo.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Updation :";
            // 
            // editBtn
            // 
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(53, 226);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(97, 31);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(205, 96);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(73, 19);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "My Email";
            // 
            // lastUpdate
            // 
            this.lastUpdate.AutoSize = true;
            this.lastUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastUpdate.ForeColor = System.Drawing.Color.White;
            this.lastUpdate.Location = new System.Drawing.Point(205, 158);
            this.lastUpdate.Name = "lastUpdate";
            this.lastUpdate.Size = new System.Drawing.Size(102, 19);
            this.lastUpdate.TabIndex = 5;
            this.lastUpdate.Text = "My Password";
            // 
            // currentTime
            // 
            this.currentTime.Location = new System.Drawing.Point(0, 0);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(100, 23);
            this.currentTime.TabIndex = 7;
            // 
            // currTime
            // 
            this.currTime.AutoSize = true;
            this.currTime.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currTime.ForeColor = System.Drawing.Color.White;
            this.currTime.Location = new System.Drawing.Point(53, 301);
            this.currTime.Name = "currTime";
            this.currTime.Size = new System.Drawing.Size(0, 19);
            this.currTime.TabIndex = 6;
            // 
            // startTimer
            // 
            this.startTimer.Enabled = true;
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.currTime);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.lastUpdate);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userProfileInfo);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(730, 555);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userProfileInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastUpdate;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Label currTime;
        private System.Windows.Forms.Timer startTimer;
    }
}
