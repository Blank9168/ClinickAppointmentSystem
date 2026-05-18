using ClinickAppointmentSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinickAppointmentSystem
{
    public partial class WelcomeFrm : Form
    {
        public WelcomeFrm()
        {
            InitializeComponent();
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            LoginFrm loginfrm = new LoginFrm();
            loginfrm.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
