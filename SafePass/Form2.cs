﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafePass
{
    public partial class SignUp : Form
    {
        private bool isMouseDown;
        private Point offset;

        public SignUp()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();    
            login.ShowDialog();  
            this.Close();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //For Moving the Form, as The Form is Borderless we have to change the positin explicitly!
            if (isMouseDown)
            {
                Point current_point = PointToScreen(e.Location);
                Location = new Point(current_point.X - offset.X, current_point.Y - offset.Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //Current Position when mouse is Down
            offset.X = e.X;
            offset.Y = e.Y;
            isMouseDown = true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void signUpBtn_MouseEnter(object sender, EventArgs e)
        {
            signUpBtn.ForeColor = Color.Black;
            signUpBtn.BackColor = Color.White;
        }

        private void signUpBtn_MouseLeave(object sender, EventArgs e)
        {
            signUpBtn.ForeColor = Color.White;
            signUpBtn.BackColor = Color.Black;
        }

        private void signUpBtn_MouseHover(object sender, EventArgs e)
        {
            signUpBtn.ForeColor = Color.Black;
            signUpBtn.BackColor = Color.White;
        }
    }
}
