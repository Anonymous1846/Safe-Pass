namespace SafePass
{
    partial class PassGen
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
            this.label1 = new System.Windows.Forms.Label();
            this.generatedPasswordTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentStrength = new System.Windows.Forms.Label();
            this.passwordStrengthMeter = new System.Windows.Forms.HScrollBar();
            this.copyToClipBoard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toggle_visibility = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Generator";
            // 
            // generatedPasswordTextBox
            // 
            this.generatedPasswordTextBox.Location = new System.Drawing.Point(72, 63);
            this.generatedPasswordTextBox.Name = "generatedPasswordTextBox";
            this.generatedPasswordTextBox.Size = new System.Drawing.Size(376, 24);
            this.generatedPasswordTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toggle_visibility);
            this.groupBox1.Controls.Add(this.currentStrength);
            this.groupBox1.Controls.Add(this.passwordStrengthMeter);
            this.groupBox1.Controls.Add(this.copyToClipBoard);
            this.groupBox1.Controls.Add(this.generatedPasswordTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(35, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 404);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Password is Ready";
            // 
            // currentStrength
            // 
            this.currentStrength.AutoSize = true;
            this.currentStrength.Location = new System.Drawing.Point(72, 225);
            this.currentStrength.Name = "currentStrength";
            this.currentStrength.Size = new System.Drawing.Size(0, 18);
            this.currentStrength.TabIndex = 5;
            // 
            // passwordStrengthMeter
            // 
            this.passwordStrengthMeter.Location = new System.Drawing.Point(72, 179);
            this.passwordStrengthMeter.Name = "passwordStrengthMeter";
            this.passwordStrengthMeter.Size = new System.Drawing.Size(314, 27);
            this.passwordStrengthMeter.TabIndex = 4;
            this.passwordStrengthMeter.Scroll += new System.Windows.Forms.ScrollEventHandler(this.passwordStrengthMeter_Scroll);
            // 
            // copyToClipBoard
            // 
            this.copyToClipBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyToClipBoard.Location = new System.Drawing.Point(72, 117);
            this.copyToClipBoard.Name = "copyToClipBoard";
            this.copyToClipBoard.Size = new System.Drawing.Size(155, 40);
            this.copyToClipBoard.TabIndex = 3;
            this.copyToClipBoard.Text = "Copy ";
            this.copyToClipBoard.UseVisualStyleBackColor = true;
            this.copyToClipBoard.Click += new System.EventHandler(this.copyToClipBoard_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 141);
            this.label2.TabIndex = 6;
            this.label2.Text = "Using the password generator is simple, just drag to increase the password streng" +
    "th and it will give you a strong password.\r\n";
            // 
            // toggle_visibility
            // 
            this.toggle_visibility.AutoSize = true;
            this.toggle_visibility.Location = new System.Drawing.Point(250, 117);
            this.toggle_visibility.Name = "toggle_visibility";
            this.toggle_visibility.Size = new System.Drawing.Size(116, 18);
            this.toggle_visibility.TabIndex = 6;
            this.toggle_visibility.TabStop = true;
            this.toggle_visibility.Text = "Toggle Visibility";
            this.toggle_visibility.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.toggle_visibility_LinkClicked);
            // 
            // PassGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "PassGen";
            this.Size = new System.Drawing.Size(730, 555);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox generatedPasswordTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button copyToClipBoard;
        private System.Windows.Forms.HScrollBar passwordStrengthMeter;
        private System.Windows.Forms.Label currentStrength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel toggle_visibility;
    }
}
