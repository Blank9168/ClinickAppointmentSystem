using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinickAppointmentSystem.Forms
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //String admin = "admin";
            //String adminPass = "admin123";

            //if (txtUsername.Text == admin && txtPassword.Text == adminPass)
            //{
            //    MessageBox.Show("Login successful!");
            AdminFrm adminFrm = new AdminFrm();
            adminFrm.Show();
            this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username or password.");
            //}


        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}