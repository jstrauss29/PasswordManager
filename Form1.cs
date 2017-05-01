using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            EditSettings settings = new EditSettings();
            settings.setLength(txtLength.Text);
            settings.setSettings(txtLength.Text, txtSpecial.Text, chkCapital.Checked, chkNumber.Checked, chkSpecChar.Checked);
            /*If we cannot get the settings stuff working delete the two lines of code above this and it should use the set defaults to run correctly*/ 
            PasswordGenorator password = new PasswordGenorator();
            lblPassword.Text = password.generatePassword(settings.getLength(), settings.getCapitals(), settings.getNumber(), settings.getSpecialChar(), settings.getSpecialCharOptions());
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void chkCapital_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void lblErrorMessages_Click(object sender, EventArgs e)
        {

        }
    }
}
