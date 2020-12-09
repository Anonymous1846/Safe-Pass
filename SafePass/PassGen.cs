using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafePass
{
    public partial class PassGen : UserControl
    {
        private static PassGen pasGenInstance;
        Random ramdomCharactergenerator;
        
        //All Possible Values of the Password !

        String allPosibleCharacters = "qwertyuiopasdfghklzxcvbnm" +
            "mQWERTYUIOPASDFGHJKLXCVBNM1234567890-=_+{}[]<>?/!@#$%^&*()";
        public static PassGen PasGenInstance
        {
            //Getting the Instance !
            get
            {
                if (pasGenInstance == null)
                    pasGenInstance = new PassGen();
                return pasGenInstance;

            }
        }
        public PassGen()
        {
            InitializeComponent();
            ramdomCharactergenerator = new Random();
        }

        private void copyToClipBoard_Click(object sender, EventArgs e)
        {
            //The Newly Genrated Password Will be Copied to the ClipBoard !
            Clipboard.SetText(generatedPasswordTextBox.Text);
        }

        private void passwordStrengthMeter_Scroll(object sender, ScrollEventArgs e)
        {
            //A String variable with null is set at first to store the password 
            String newPassword = "";
            //The Size of the new password is set to the Current Scroll Value and May be Subjected to change !
            int sizeOfThePassword = (passwordStrengthMeter.Value)/4;
            //A Character is randomly chosen from the allPossibleString and Appended to the newPassword String 
            for (int i=0;i<sizeOfThePassword;i++)
            {
                //Character chosen at random from index 0 to the size of the String variable !
                newPassword += allPosibleCharacters[ramdomCharactergenerator.Next(0,allPosibleCharacters.Length)];
            }
            //Current Password is Shown and The Strength is also shown !
            generatedPasswordTextBox.Text = newPassword;
            currentStrength.Text = $"Current Password Strength is {sizeOfThePassword} characters ";
        }

        private void toggle_visibility_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//Toogle Password Visibility 
           
            if (generatedPasswordTextBox.PasswordChar.Equals('*'))
            {
                //If * then convert back to normal 
                generatedPasswordTextBox.PasswordChar = '\0';
            }
            else
                //Asterisk
                generatedPasswordTextBox.PasswordChar = '*';
        }
    }
}
