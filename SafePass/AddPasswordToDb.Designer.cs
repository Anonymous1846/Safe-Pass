namespace SafePass
{
    partial class AddPasswordToDb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPasswordToDb));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addBtnAdding = new System.Windows.Forms.Button();
            this.usernameAdding = new System.Windows.Forms.TextBox();
            this.userPasswordAdding = new System.Windows.Forms.TextBox();
            this.errorForUseernameAdding = new System.Windows.Forms.Label();
            this.errorForPasswordAdding = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nickName = new System.Windows.Forms.TextBox();
            this.nickNameError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(747, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Password ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username/Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password :";
            // 
            // addBtnAdding
            // 
            this.addBtnAdding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtnAdding.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtnAdding.ForeColor = System.Drawing.Color.White;
            this.addBtnAdding.Location = new System.Drawing.Point(25, 266);
            this.addBtnAdding.Name = "addBtnAdding";
            this.addBtnAdding.Size = new System.Drawing.Size(90, 38);
            this.addBtnAdding.TabIndex = 4;
            this.addBtnAdding.Text = "Add";
            this.addBtnAdding.UseVisualStyleBackColor = true;
            this.addBtnAdding.Click += new System.EventHandler(this.addBtnAdding_Click);
            this.addBtnAdding.MouseEnter += new System.EventHandler(this.addBtnAdding_MouseEnter);
            this.addBtnAdding.MouseLeave += new System.EventHandler(this.addBtnAdding_MouseLeave);
            // 
            // usernameAdding
            // 
            this.usernameAdding.Location = new System.Drawing.Point(194, 85);
            this.usernameAdding.Name = "usernameAdding";
            this.usernameAdding.Size = new System.Drawing.Size(380, 22);
            this.usernameAdding.TabIndex = 5;
            // 
            // userPasswordAdding
            // 
            this.userPasswordAdding.Location = new System.Drawing.Point(194, 138);
            this.userPasswordAdding.Name = "userPasswordAdding";
            this.userPasswordAdding.PasswordChar = '*';
            this.userPasswordAdding.Size = new System.Drawing.Size(380, 22);
            this.userPasswordAdding.TabIndex = 6;
            // 
            // errorForUseernameAdding
            // 
            this.errorForUseernameAdding.AutoSize = true;
            this.errorForUseernameAdding.ForeColor = System.Drawing.Color.Red;
            this.errorForUseernameAdding.Location = new System.Drawing.Point(194, 115);
            this.errorForUseernameAdding.Name = "errorForUseernameAdding";
            this.errorForUseernameAdding.Size = new System.Drawing.Size(0, 17);
            this.errorForUseernameAdding.TabIndex = 7;
            // 
            // errorForPasswordAdding
            // 
            this.errorForPasswordAdding.AutoSize = true;
            this.errorForPasswordAdding.ForeColor = System.Drawing.Color.Red;
            this.errorForPasswordAdding.Location = new System.Drawing.Point(194, 167);
            this.errorForPasswordAdding.Name = "errorForPasswordAdding";
            this.errorForPasswordAdding.Size = new System.Drawing.Size(0, 17);
            this.errorForPasswordAdding.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nick Name :";
            // 
            // nickName
            // 
            this.nickName.Location = new System.Drawing.Point(194, 199);
            this.nickName.Name = "nickName";
            this.nickName.Size = new System.Drawing.Size(380, 22);
            this.nickName.TabIndex = 10;
            // 
            // nickNameError
            // 
            this.nickNameError.AutoSize = true;
            this.nickNameError.ForeColor = System.Drawing.Color.Red;
            this.nickNameError.Location = new System.Drawing.Point(194, 241);
            this.nickNameError.Name = "nickNameError";
            this.nickNameError.Size = new System.Drawing.Size(0, 17);
            this.nickNameError.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(617, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Toggle";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AddPasswordToDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nickNameError);
            this.Controls.Add(this.nickName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.errorForPasswordAdding);
            this.Controls.Add(this.errorForUseernameAdding);
            this.Controls.Add(this.userPasswordAdding);
            this.Controls.Add(this.usernameAdding);
            this.Controls.Add(this.addBtnAdding);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPasswordToDb";
            this.Text = "Form3";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddPasswordToDb_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddPasswordToDb_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddPasswordToDb_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBtnAdding;
        private System.Windows.Forms.TextBox usernameAdding;
        private System.Windows.Forms.TextBox userPasswordAdding;
        private System.Windows.Forms.Label errorForUseernameAdding;
        private System.Windows.Forms.Label errorForPasswordAdding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nickName;
        private System.Windows.Forms.Label nickNameError;
        private System.Windows.Forms.Label label5;
    }
}